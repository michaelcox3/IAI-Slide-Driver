using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using PCONController;
using System.Threading;

namespace IAIProject
{
    public partial class MainForm : Form
    {
        Controller slide;
        List<Preset> presetList;
        private string file;
        private bool inchUp;
        private bool jogUp;
        public MainForm()
        {
            InitializeComponent();
            slide = new Controller();
            presetList = new List<Preset>();
            file = "presets.txt";

            slide.LimitExceeded += OnLimitExceeded; // register with an event

            NumAmpLimit.Value = Properties.Settings.Default.ampUp;
            NumAmpDownLimit.Value = Properties.Settings.Default.ampDown;

            slide.settings.ampUpLimit = Properties.Settings.Default.ampUp;
            slide.settings.ampDownLimit = Properties.Settings.Default.ampDown;
            

            TextTimer.Start();
        }



        #region Load/Close & Timers
        private void Form1_Load(object sender, EventArgs e)
        {
            // Find all serial ports open on current pc and add them to the drop down box
            String[] AvailablePorts = System.IO.Ports.SerialPort.GetPortNames();
            for(int i = 0; i < AvailablePorts.Length; i++)
            {
                SerialPortsAvail.Items.Add(AvailablePorts[i]);
            }
            // Set slide port settings to the first COM port read from pc
            if (AvailablePorts.Length > 0)
            {
                slide.Port = AvailablePorts[0];
                SerialPortsAvail.Text = AvailablePorts[0];
            }
            else
            {
                slide.Port = "COM1";
            }

            // Load presets
            LoadPresets();

            // Initialize preset ComboBox fields
            if(presetList.Count > 0)
            {
                CBPresets.Text = presetList[0].name;
            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            slide.AlarmReset();
            slide.SetPower(false);
            System.Threading.Thread.Sleep(100);
            slide.CloseThreads();

            //Save AmpLimit values
            Properties.Settings.Default.ampUp = (int) NumAmpLimit.Value;
            Properties.Settings.Default.ampDown = (int) NumAmpDownLimit.Value;
            Properties.Settings.Default.Save();

            SavePresets();
        }


        // Update text fields every 50ms
        private void TextTimer_Tick(object sender, EventArgs e)
        {
            //Connection Status
            if (slide.Connected())
            {
                BtnConnect.Text = "Disconnect";
                toolStripStatusLabel1.Text = "Connected";
                statusStrip1.BackColor = Color.LightGreen;
                if (slide.state.SV)
                {
                    TbServoStatus.Text = "ON";
                    TbServoStatus.BackColor = Color.LightGreen;
                }
                else
                {
                    TbServoStatus.Text = "OFF";
                    TbServoStatus.BackColor = Color.Red;
                }

                if (slide.state.ALMC != 0)
                {
                    BtnResetAlarm.BackColor = Color.Red;
                } else
                {
                    BtnResetAlarm.BackColor = System.Drawing.SystemColors.ControlLight;
                }
                TbCurPos.Text = slide.state.PNOW.ToString();
                TbCurAmps.Text = slide.state.CNOW.ToString();
                TbCurSpeed.Text = slide.state.VNOW.ToString();
                TbAlarmCode.Text = slide.state.ALMC.ToString("X");
            }
            else
            {
                BtnConnect.Text = "Connect";
                toolStripStatusLabel1.Text = "Not Connected";
                statusStrip1.BackColor = Color.Red;
            }
        }
        #endregion


        #region Buttons
        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!slide.Connected())
                {
                    slide.Connect();
                }
                else
                {
                    slide.Disconnect();
                }
            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            slide.Disconnect();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            slide.StopMotion();
        }

        private void BtnJogDn_MouseDown(object sender, MouseEventArgs e)
        {
            slide.state.jogOrInch = true;
            jogUp = false;
            slide.state.jogDown = true;
            slide.RelativeMove(10);

            //continue to jog when button is held down
            JogLoop.Start();
        }

        private void BtnJogUp_MouseDown(object sender, MouseEventArgs e)
        {
            slide.state.jogOrInch = true;
            jogUp = true;
            slide.state.jogUp = true;
            slide.RelativeMove(-10);

            //continue to jog when button is held down
            JogLoop.Start();
        }

        private void BtnServoOn_Click(object sender, EventArgs e)
        {
            try
            {
                slide.SetPower(true);
            }
            catch(Exception exception)
            {
                MessageBox.Show(Text, exception.Message);
            }
        }

        private void BtnServoOff_Click(object sender, EventArgs e)
        {
            slide.SetPower(false);
        }


        private void BtnHome_Click(object sender, EventArgs e)
        {
            slide.state.jogOrInch = false;
            slide.Home();
        }

        private void BtnAbsMove_Click(object sender, EventArgs e)
        {
            slide.state.jogOrInch = false;
            slide.AbsoluteMove((double) NumAbsMove.Value);
        }

        private void BtnResetAlarm_Click(object sender, EventArgs e)
        {
            slide.AlarmReset();
        }
        #endregion


        #region Combo Boxes
        private void SerialPortsAvail_SelectedIndexChanged(object sender, EventArgs e)
        {
            slide.Port = SerialPortsAvail.SelectedItem.ToString();
        }

        private void BaudList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //slide.Baud = int.Parse(BaudList.SelectedItem.ToString());
        }
        private void CBPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < presetList.Count; i++)
            {
                if (i == CBPresets.SelectedIndex)
                {
                    TbPresetPos.Text = presetList[i].position.ToString();
                }
            }
        }
        #endregion


        #region Preset Methods
        //Reads from the presets.txt file and stores the data into a List<preset>
        public void LoadPresets()
        {
            Console.WriteLine("Loading presets...");
            if (!File.Exists(file))
            {
                File.Create(file);
            }
            string fullFilePath = Path.Combine(Directory.GetCurrentDirectory(), file);
            Console.Write("Path : " + fullFilePath);
            ReadPresets(file);
        }

        public void SavePresets()
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(file);
                foreach (Preset preset in presetList)
                {
                    Console.WriteLine(preset.name);
                    streamWriter.WriteLine(preset.name + ", " + preset.position);
                }
                streamWriter.Close();
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void BtnGoToPreset_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(TbPresetPos.Text, out input))
            {
                slide.state.jogOrInch = false;
                slide.AbsoluteMove(input);
            }
        }
        private void BtnNewPreset_Click(object sender, EventArgs e)
        {
            Preset preset = CustomInputControl.NameAndPos("Name:", "Create New Preset");
            if (preset.name != null && preset.position != 0)
            {
                presetList.Add(preset);
                CBPresets.Items.Add(preset.name);
            }
        }

        private void BtnAddPreset_Click(object sender, EventArgs e)
        {
            String name = CustomInputControl.ShowDialog("Enter Preset Name:", "Presets");

            //slide.UpdateStatus();
            double position = slide.state.PNOW;
            Preset newPreset = new Preset(name, position);
            presetList.Add(newPreset);
            CBPresets.Items.Add(newPreset.name);
        }

        private void BtnDelPreset_Click(object sender, EventArgs e)
        {
            int selectedIndex = CBPresets.SelectedIndex;

            Console.WriteLine(selectedIndex);
            if (selectedIndex >= 0)
            {
                presetList.RemoveAt(selectedIndex);
                CBPresets.Items.RemoveAt(selectedIndex);
                TbPresetPos.Text = "";
            }
        }

        private void ReadPresets(string file)
        {
            presetList.Clear();
            try
            {
                StreamReader streamReader = new StreamReader(file);
                string line = streamReader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    string[] parts = line.Split(',');
                    Preset preset = new Preset(parts[0], double.Parse(parts[1]));
                    presetList.Add(preset);
                    line = streamReader.ReadLine();
                }
                streamReader.Close();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception: " + exception);
            }

            //write to the CBPresets array
            CBPresets.Items.Clear();
            foreach (Preset preset in presetList)
            {
                Console.WriteLine(preset.name);
                CBPresets.Items.Add(preset.name);
            }

        }
        #endregion

        private void OnLimitExceeded(object sender, EventArgs e)
        {
            MessageBox.Show("Amp Limit exceeded! Servo powered off", "Error");
        }

        private void NumAmpLimit_ValueChanged(object sender, EventArgs e)
        {
            slide.settings.ampUpLimit = (int) NumAmpLimit.Value;
        }
        private void NumAmpDownLimit_ValueChanged(object sender, EventArgs e)
        {
            slide.settings.ampDownLimit = (int)NumAmpDownLimit.Value;
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            Form aboutBox = new Form();
            aboutBox.Width = 350;
            aboutBox.Height = 150;
            aboutBox.Padding = System.Windows.Forms.Padding.Empty;
            aboutBox.Text = "About";
            aboutBox.SizeGripStyle = SizeGripStyle.Hide;

            Label aboutLabel = new Label() 
            { 
                Left = 0, 
                Top = 0, 
                Width = 350, 
                Height = 150, 
                Text = "Michael Cox (2023).\r\nIncluded in this source code is the EasyModbus library provided by Stefan Robmann."
            };
            aboutLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular);
            aboutLabel.TextAlign = ContentAlignment.MiddleCenter;
            aboutLabel.AutoSize = false;
            aboutLabel.Dock = DockStyle.Fill;

            aboutBox.Controls.Add(aboutLabel);
            aboutBox.ShowDialog();
        }

        private void errorCodeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.intelligentactuator.com/e-con-error-codes-descriptions/");
        }

        private void additionalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.intelligentactuator.com/pdf/manuals/PCON-CCG-Controller_Manual_v4.pdf");
        }

        private void loadPresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Preset Text File";
            theDialog.Filter = "Text Files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                ReadPresets(theDialog.FileName);
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void savePresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog theDialog = new SaveFileDialog();
            theDialog.Title = "Save Preset Text File";
            theDialog.InitialDirectory = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            theDialog.Filter = "Text Files|*.txt";

            if(theDialog.ShowDialog() == DialogResult.OK)
            {
                string saveFile = theDialog.FileName;
                StreamWriter streamWriter = new StreamWriter(saveFile);
                foreach (Preset preset in presetList)
                {
                    streamWriter.WriteLine(preset.name + ", " + preset.position);
                }
                streamWriter.Flush();
                streamWriter.Close();
            }
        }

        private void InchLoop_Tick(object sender, EventArgs e)
        {
            if (inchUp)
            {
                double value = -double.Parse(NumRelMove.Value.ToString());
                slide.RelativeMove(value, 1000);
            }
            else
            {
                double value = double.Parse(NumRelMove.Value.ToString());
                slide.RelativeMove(value, 1000);
            }
        }

        private void JogLoop_Tick(object sender, EventArgs e)
        {
            if (jogUp)
            {
                slide.RelativeMove(-10);
            }
            else
            {
                slide.RelativeMove(10);
            }
        }


        private void BtnInchDn_MouseDown(object sender, MouseEventArgs e)
        {
            slide.state.jogOrInch = true;
            inchUp = false;
            slide.state.inchDown = true;

            double value = double.Parse(NumRelMove.Value.ToString());
            slide.RelativeMove(value, 1000);

            //continue to loop while holding down
            InchLoop.Start();
        }

        private void BtnInchUp_MouseDown(object sender, MouseEventArgs e)
        {
            slide.state.jogOrInch = true;
            inchUp = true;
            slide.state.inchUp = true;

            double value = -double.Parse(NumRelMove.Value.ToString());
            slide.RelativeMove(value, 1000);

            //continue to loop while holding down
            InchLoop.Start();
        }

        //call when releasing the jog or inch buttons
        private void BtnInchUp_MouseUp(object sender, MouseEventArgs e)
        {
            InchLoop.Stop();
            JogLoop.Stop();
            slide.StopMotion();

            //set all jog/inch states to false (used in the amp limit loop)
            slide.state.jogUp = false;
            slide.state.jogDown = false;
            slide.state.inchUp = false;
            slide.state.inchDown = false;
            slide.state.jogOrInch = false;
        }
    }

    public static class CustomInputControl
    {
        public static string ShowDialog(string label, string title)
        {
            Form inputBox = new Form();
            inputBox.Width = 300;
            inputBox.Height = 200;
            inputBox.Text = title;

            Label lbl = new Label() { Left = 40, Top = 40, Text = label};

            TextBox txtInput = new TextBox() { Left = 40, Top = 70, Width = 200 };

            Button btnConfirm = new Button() { Text = "Ok", Left = 40, Top = 100, Width = 100 };
            btnConfirm.Click += (sender, e) => {
                try
                {
                    Regex regex = new Regex(@"^[a-zA-Z0-9_.-]*$");
                    MatchCollection matches = regex.Matches(txtInput.Text);
                    if (matches.Count > 0 && txtInput.Text != "")
                    {
                        Console.WriteLine(matches.Count);
                        inputBox.Close();
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Please input a preset name. (No spaces allowed)");
                }
            };

            inputBox.Controls.Add(lbl);
            inputBox.Controls.Add(txtInput);
            inputBox.Controls.Add(btnConfirm);

            inputBox.ShowDialog();
            return txtInput.Text;
        }

        public static Preset NameAndPos(string label, string title)
        {

            Preset preset = new Preset();

            Form inputBox = new Form();
            inputBox.Width = 300;
            inputBox.Height = 200;
            inputBox.Text = title;

            Label name = new Label() { Left = 20, Top = 30, Text = "Name", Width = 60, Height = 20 };
            Label pos = new Label() { Left = 20, Top = 60, Text = "Position (mm)", Width = 60, Height = 20 };

            TextBox txtInput = new TextBox() { Left = 100, Top = 30, Width = 100 };
            TextBox posInput = new TextBox() { Left = 100, Top = 60, Width = 100 };

            Button btnConfirm = new Button() { Text = "Ok", Left = 40, Top = 100, Width = 100 };

            btnConfirm.Click += (sender, e) => {
                try
                {
                    Regex regex = new Regex(@"^[a-zA-Z0-9_.-]*$");
                    MatchCollection matches = regex.Matches(txtInput.Text);
                    if (matches.Count > 0 && txtInput.Text != "")
                    {
                        preset.name = txtInput.Text;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                    double position = double.Parse(posInput.Text);
                    position = Math.Round(position, 2);
                    preset.position = position;
                    inputBox.Close();
                }
                catch(System.FormatException)
                {
                    MessageBox.Show("Please input and name and a decimal number. (No spaces allowed)");
                }
            };

            inputBox.Controls.Add(name);
            inputBox.Controls.Add(pos);
            inputBox.Controls.Add(txtInput);
            inputBox.Controls.Add(btnConfirm);
            inputBox.Controls.Add(posInput);
            

            inputBox.ShowDialog();
            return preset;
        }

    }

}
