using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using EasyModbus;

namespace PCONController
{
    public class Controller : Controller_Interface
    {
        #region "Data of Status/Command Registers"

        // ---------Status Coils-------- 
        //Reg  Symbol  Description
        //0100 EMGS    EMG status 
        //0101 SFTY    Safety speed enabled status
        //0102 PWR     Controller ready status 
        //0103 SV      Servo ON status 
        //0104 PSFL    Missed work in push-motion operation 
        //0105 ALMH    Major failure status 
        //0106 ALML    Minor failure status 
        //0107 ABER    Absolute error status ABER
        //0108 BKRL    Brake forced-release status 
        //010A STP     Pause status 
        //010B HEND    Home return status 
        //010C PEND    Position complete status 
        //0112 LOAD    Load output judgment status 
        //0113 TRQS    Torque level status 
        //0114 MODS    Teaching mode status 
        //0115 TEAC    Position-data load command status 
        //0116 JOG+    Jog+ status 
        //0117 JOG-    Jog- status  
        //0118 PE7     Position complete 7 
        //0119 PE6     Position complete 6 
        //011A PE5     Position complete 5 
        //011B PE4     Position complete 4 
        //011C PE3     Position complete 3 
        //011D PE2     Position complete 2 
        //011E PE1     Position complete 1 
        //011F PE0     Position complete 0
        //012A moving or not

        //---------Status Registers-------- 
        //Reg  Symbol  Description
        //9000 PNOW    Current Position Monitor (high byte)
        //9001 PNOW    Current Position Monitor (low byte)
        //9002 ALMC    Present alarm code query
        //9003 DIPM    Input port query
        //9004 DOPM    Ouput port monitor query
        //9005 DSS1    Device status query 1
        //9006 DSS2    Device status query 2
        //9007 DSSE    Expansion device status query
        //9008 STAT    System status query (high byte)
        //9009 STAT    System status query (low byte)
        //900A VNOW    Current speed monitor (high byte)
        //900B VNOW    Current speed monitor (low byte)
        //900C CNOW    Current ampere monitor (high byte)
        //900D CNOW    Current ampere monitor (low byte)
        //900E DEVI    Deviation Monitor (high byte)
        //900F DEVI    Deviation Monitor (low byte)
        //9010 STIM    System timer query (high byte)
        //9011 STIM    System timer query (low byte)
        //9012 SIPM    Special input port query
        //9013 ZONS    Zone status query
        //9014 POSS    Position complete number status query

        //---------Commands Coils--------
        //Reg  Symbol  Description
        //0400 EMG     EMG operation specification 
        //0401 SFTY    Safety speed command 
        //0403 SON     Servo ON command 
        //0407 ALRS    Alarm reset command 
        //0408 BKRL    Brake forced-release command 
        //040A STP     Pause command 
        //040B HOME    Home return command 
        //040C CSTR    Positioning start command 
        //0411 JISL    Jog/inch switching 
        //0414 MOD     Teaching mode command 
        //0415 TEAC    Position data load command 
        //0416 JOG+    Jog+ command 
        //0417 JOG-    Jog command 
        //0418 ST7     Start position 7 
        //0419 ST6     Start position 6 
        //041A ST5     Start position 5 
        //041B ST4     Start position 4 
        //041C ST3     Start position 3 
        //041D ST2     Start position 2 
        //041E ST1     Start position 1 
        //041F ST0     Start position 0
        //042C STOP    Decelerate to a stop
        //*Most coils are high as FF00 and low as 0000

        //---------Command Registers--------
        //9900 PCMD    Target position specification register
        //9902 INP     Positioning band specification register
        //9904 VCMD    Speed specification register
        //9906 ACMD    Accel/decel specification register
        //9907 PPOW    Push-current limiting value specification register
        //9908 CTLF    Control flag specification register

        #endregion

        #region "Register Constants"

        //-----------------------Status Coil Addresses----------------------------
        /*
        private int REG_STAT_EMGS = 0x100;     //EMG status 
        private int REG_STAT_SFTY = 0x101;     //Safety speed enabled status
        private int REG_STAT_PWR = 0x102;      //Controller ready status 
        private int REG_STAT_SV = 0x103;       //Servo ON status 
        private int REG_STAT_PSFL = 0x104;     //Missed work in push-motion operation 
        private int REG_STAT_ALMH = 0x105;     //Major failure status 
        private int REG_STAT_ALML = 0x106;     //Minor failure status 
        private int REG_STAT_ABER = 0x107;     //Absolute error status ABER
        private int REG_STAT_BKRL = 0x108;     //Brake forced-release status 
        private int REG_STAT_STP = 0x10A;      //Pause status 
        private int REG_STAT_HEND = 0x10B;     //Home return status 
        private int REG_STAT_PEND = 0x10C;     //Position complete status 
        private int REG_STAT_LOAD = 0x112;     //Load output judgment status 
        private int REG_STAT_TRQS = 0x113;     //Torque level status 
        private int REG_STAT_MODS = 0x114;     //Teaching mode status 
        private int REG_STAT_TEAC = 0x115;     //Position-data load command status 
        private int REG_STAT_JOGUP = 0x116;    //Jog+ status 
        private int REG_STAT_JOGDN = 0x117;    //Jog- status  
        private int REG_STAT_PE7 = 0x118;      //Position complete 7 
        private int REG_STAT_PE6 = 0x119;      //Position complete 6 
        private int REG_STAT_PE5 = 0x11A;      //Position complete 5 
        private int REG_STAT_PE4 = 0x11B;      //Position complete 4 
        private int REG_STAT_PE3 = 0x11C;      //Position complete 3 
        private int REG_STAT_PE2 = 0x11D;      //Position complete 2 
        private int REG_STAT_PE1 = 0x11E;      //Position complete 1 
        private int REG_STAT_PE0 = 0x11F;      //Position complete 0
        */
        private readonly int REG_STAT_SV = 0x103;       //Servo ON status 
        //-----------------------Status Register Addresses----------------------------
        /*
        private int REG_STAT_PNOW_HI = 0x9000;     //Current Position Monitor (high byte)
        private int REG_STAT_PNOW_LO = 0x9001;     //Current Position Monitor (low byte)
        private int REG_STAT_ALMC = 0x9002;        //Present alarm code query
        private int REG_STAT_DIPM = 0x9003;        //Input port query
        private int REG_STAT_DOPM = 0x9004;        //Ouput port monitor query
        private int REG_STAT_DSS1 = 0x9005;        //Device status query 1
        private int REG_STAT_DSS2 = 0x9006;        //Device status query 2
        private int REG_STAT_DSSE = 0x9007;        //Expansion device status query
        private int REG_STAT_STAT_HI = 0x9008;     //System status query (high byte)
        private int REG_STAT_STAT_LO = 0x9009;     //System status query (low byte)
        private int REG_STAT_VNOW_HI = 0x900A;     //Current speed monitor (high byte)
        private int REG_STAT_VNOW_LO = 0x900B;     //Current speed monitor (low byte)
        private int REG_STAT_CNOW_HI = 0x900C;     //Current ampere monitor (high byte)
        private int REG_STAT_CNOW_LO = 0x900D;     //Current ampere monitor (low byte)
        private int REG_STAT_DEVI_HI = 0x900E;     //Deviation Monitor (high byte)
        private int REG_STAT_DEVI_LO = 0x900F;     //Deviation Monitor (low byte)
        private int REG_STAT_STIM_HI = 0x9010;     //System timer query (high byte)
        private int REG_STAT_STIM_LO = 0x9011;     //System timer query (low byte)
        private int REG_STAT_SIPM = 0x9012;        //Special input port query
        private int REG_STAT_ZONS = 0x9013;        //Zone status query
        private int REG_STAT_POSS = 0x9014;        //Position complete number status query
        */
        //-----------------------Command Coil Addresses----------------------------
        //private int REG_CMD_EMG = 0x400;       //EMG operation specification 
        private readonly int REG_CMD_SFTY = 0x401;      //Safety speed command 
        private readonly int REG_CMD_SON = 0x403;       //Servo On command 
        private readonly int REG_CMD_ALRS = 0x407;      //Alarm reset command 
        private readonly int REG_CMD_BKRL = 0x408;      //Brake forced-release command 
        //private int REG_CMD_STP = 0x40A;       //Pause command 
        private readonly int REG_CMD_HOME = 0x40B;      //Home Return command 
        //private int REG_CMD_CSTR = 0x40C;      //Positioning start command 
        private readonly int REG_CMD_JISL = 0x411;      //Jog/inch switching 
        //private int REG_CMD_MOD = 0x414;       //Teaching mode command 
        //private int REG_CMD_TEAC = 0x415;      //Position data load command 
        private readonly int REG_CMD_JOGDN = 0x416;     //Jog- command 
        private readonly int REG_CMD_JOGUP = 0x417;     //Jog+ command
        /*
        private int REG_CMD_ST7 = 0x418;       //Start position 7 
        private int REG_CMD_ST6 = 0x419;       //Start position 6 
        private int REG_CMD_ST5 = 0x41A;       //Start position 5 
        private int REG_CMD_ST4 = 0x41B;       //Start position 4 
        private int REG_CMD_ST3 = 0x41C;       //Start position 3 
        private int REG_CMD_ST2 = 0x41D;       //Start position 2 
        private int REG_CMD_ST1 = 0x41E;       //Start position 1 
        private int REG_CMD_ST0 = 0x41F;       //Start position 0
        */
        private readonly int REG_CMD_STOP = 0x42C;      //Decelerate To a Stop

        //-----------------------Command Register Addresses----------------------------
        private readonly int REG_CMD_PCMD = 0x9900;     //Target position specification register (Absolute move: 0.01mm)
        //private int REG_CMD_INP = 0x9902;      //Positioning band specification register
        private readonly int REG_CMD_VCMD = 0x9904;     //Speed specification register
        private readonly int REG_CMD_ACMD = 0x9906;     //Accel/decel specification register
        //private readonly int REG_CMD_PPOW = 0x9907;     //Push-current limiting value specification register
        private int REG_CMD_CTLF = 0x9908;     //Control flag specification register
        #endregion

        #region Variables / Getters & Setters
        private ModbusClient modbusClient;
        public PCONState state;
        public PCONSettings settings;
        private Thread thread;
        private Thread readThread;

        // Queues for writing
        private ConcurrentQueue<KeyValuePair<int, bool>> writeCoilQueue = new ConcurrentQueue<KeyValuePair<int, bool>>();
        private ConcurrentQueue<KeyValuePair<int, int>> writeRegisterQueue = new ConcurrentQueue<KeyValuePair<int, int>>();
        private ConcurrentQueue<KeyValuePair<int, int[]>> writeRegistersQueue = new ConcurrentQueue<KeyValuePair<int, int[]>>();

        // Queues for reading
        //private ConcurrentQueue<bool> readCoilQueue = new ConcurrentQueue<bool>();
        private ConcurrentQueue<KeyValuePair<int, int>> readRegistersQueue = new ConcurrentQueue<KeyValuePair<int, int>>();
        

        private String port = "COM1";
        private int baud = 38400;
        public int ampLimit = 350;
        public bool ampLimitActive = true;

        public string Port { get => port; set => port = value; }
        public int Baud { get => baud; set => baud = value; }



        #endregion


        #region Constructors

        // Constrructor that builds modBusClient with default parameters (values above)
        public Controller()
        {
            modbusClient = new ModbusClient();
            state = new PCONState();
            settings = new PCONSettings();
            Console.WriteLine(System.IO.Ports.SerialPort.GetPortNames().ToString());
            if(System.IO.Ports.SerialPort.GetPortNames().Length > 0)
            {
                // Set SerialPort to the first SerialPort active on pc
                modbusClient.SerialPort = System.IO.Ports.SerialPort.GetPortNames()[0];
            }
            else
            {
                modbusClient.SerialPort = port;
            }
            modbusClient.UnitIdentifier = 1; //Not necessary since default slaveID = 1;
            modbusClient.Baudrate = 38400;   // Not necessary since default baudrate = 9600
            modbusClient.Parity = System.IO.Ports.Parity.None;
            //modbusClient.StopBits = System.IO.Ports.StopBits.Two;
            modbusClient.ConnectionTimeout = 500;

            // Start threads
            thread = new Thread(SerialQueueLoop);
            thread.Start();
            readThread = new Thread(ReadLoop);
            readThread.Start();
        }

        // Constructor that builds modBusClient with passed parameters
        public Controller(string port, int baud)
        {
            modbusClient = new ModbusClient();
            this.port = port;
            this.baud = baud;
            modbusClient.Parity = System.IO.Ports.Parity.None;
        }

        #endregion


        #region Connection Methods
        // Connect with port and baud stored in Controller object
        public void Connect()
        {
            // Update modbusClient port and baud
            modbusClient.SerialPort = port;
            modbusClient.Baudrate = baud;
            //modbusClient.StopBits = System.IO.Ports.StopBits.Two;
            //modbusClient.Parity = System.IO.Ports.Parity.None;
            modbusClient.NumberOfRetries = 0;

            try
            {
                // Disconnect if already connected
                if (modbusClient.Connected)
                {
                    modbusClient.Disconnect();
                }
                // Connect
                modbusClient.Connect();
                state.SV = ReadCoil(REG_STAT_SV);
                System.Console.WriteLine("Connected!");
            } 
            catch (Exception e)
            {
                System.Console.WriteLine(e);
            }

        }

        // Disconnect from the serial port
        public void Disconnect()
        {
            if (modbusClient.Connected)
            {
                SetPower(false);
                modbusClient.Disconnect();
            }
        }

        // Connection status
        public bool Connected()
        {
            return modbusClient.Connected;
        }
        #endregion


        #region Control Methods
        public void AbsoluteMove(double position)
        {
            // Convert mm to 0.01mm (thats what the slider reads)
            int positionInt = (int)(Math.Round(position, 2) * 100);

            String hexString = positionInt.ToString("X");
            int pos = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            int posLo = pos & 0x0000FFFF;
            int posHi = pos >> 16;

            int[] writeRegistersData = new int[6];
            writeRegistersData[0] = posHi;
            writeRegistersData[1] = posLo;        
            writeRegistersData[2] = 1;
            writeRegistersData[3] = 1;
            writeRegistersData[4] = settings.VSETHI;  //settings.VSETHI;
            writeRegistersData[5] = settings.VSETLO;  //settings.VSETLO;
            if (state.SV)
            {
                WriteHoldingRegisters(REG_CMD_PCMD, writeRegistersData);
            }
        }

        public void AbsoluteMove(double position, int speed)
        {
            // Convert mm to 0.01mm (thats what the slider reads)
            int positionInt = (int)(Math.Round(position, 2) * 100);

            // Convert decimal to hex
            String hexString = positionInt.ToString("X");
            int pos = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            int posLo = pos & 0x0000FFFF;
            int posHi = pos >> 16;

            int[] writeRegistersData = new int[6];
            writeRegistersData[0] = posHi;
            writeRegistersData[1] = posLo;
            writeRegistersData[2] = 1;
            writeRegistersData[3] = 1;
            writeRegistersData[4] = 0;  //settings.VSETHI;
            writeRegistersData[5] = speed;  //settings.VSETLO;

            if (state.SV)
            {
                WriteHoldingRegisters(REG_CMD_PCMD, writeRegistersData);
            }
        }

        public void AlarmReset()
        {
            WriteCoil(REG_CMD_ALRS, true);
            WriteCoil(REG_CMD_ALRS, false);
        }

        public void BreakRelease(bool release)
        {
            WriteCoil(REG_CMD_BKRL, true);
            WriteCoil(REG_CMD_BKRL, false);

        }

        public void Home()
        {
            WriteCoil(REG_CMD_HOME, true);
            WriteCoil(REG_CMD_HOME, false);
        }

        public void InchDown()
        {
            WriteCoil(REG_CMD_JISL, true);
            WriteCoil(REG_CMD_JOGDN, true);
            WriteCoil(REG_CMD_JOGDN, false);
        }

        public void InchUp()
        {
            WriteCoil(REG_CMD_JISL, true);
            WriteCoil(REG_CMD_JOGUP, true);
            WriteCoil(REG_CMD_JOGUP, false);
        }

        public void JogDnStart()
        {
            WriteCoil(REG_CMD_JISL, false);
            WriteCoil(REG_CMD_JOGDN, true);
        }

        public void JogStop()
        {
            WriteCoil(REG_CMD_JOGDN, false);
            WriteCoil(REG_CMD_JOGUP, false);
        }

        public void JogUpStart()
        {
            WriteCoil(REG_CMD_JISL, false);
            WriteCoil(REG_CMD_JOGUP, true);
        }

        public void PauseMotion(bool pause)
        {
            WriteCoil(0x40A, true);
            WriteCoil(0x40A, false);
        }

        public void RelativeMove(double distance)
        {
            WriteHoldingRegister(REG_CMD_CTLF, 0x48);
            AbsoluteMove(distance);
        }

        public void RelativeMove(double distance, int speed)
        {
            WriteHoldingRegister(REG_CMD_CTLF, 0x48);
            AbsoluteMove(distance, speed);
        }

        public void SafetySpeed(bool safetyOn)
        {
            WriteCoil(REG_CMD_SFTY, safetyOn);
        }

        public void SetAccel(double input)
        {
            // Convert decimal to hex
            int accel = (int)(Math.Round(input, 2) * 100);
            String hexString = accel.ToString("X");
            int hex = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);

            WriteHoldingRegister(REG_CMD_ACMD, hex);
        }

        public void SetPower(bool power)
        {
            WriteCoil(REG_CMD_SON, power);
            state.SV = power;
        }

        public void SetSpeed(int speed)
        {
            String hexString = speed.ToString("X");
            int hex = int.Parse(hexString, System.Globalization.NumberStyles.HexNumber);
            WriteHoldingRegister(REG_CMD_VCMD + 1, hex);

        }

        public void StopMotion()
        {
            WriteCoil(REG_CMD_STOP, true);
            WriteCoil(REG_CMD_STOP, false);
            state.VNOW = 0;
        }


        #endregion


        #region Read/Write to Coils/Registers Methods
        // Read a single coil at register
        public bool ReadCoil(int register) 
        {
            bool result = false;
            if (modbusClient.Connected)
            {
                try
                {
                    result = modbusClient.ReadCoils(register, 1)[0];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return result;
        }

        // Read multiple coils starting at a register
        public bool[] ReadMultipleCoils(int register, int quantity)
        {
            return modbusClient.ReadCoils(register, quantity);
        }

        // Write a single coil at register
        public void WriteCoil(int register, bool bit)
        {
            if (modbusClient.Connected)
            {
                writeCoilQueue.Enqueue(new KeyValuePair<int, bool>(register, bit));
            }
        }

        // Read holding register at register
        public int ReadHoldingRegister(int register)
        {
            try
            {
                return modbusClient.ReadHoldingRegisters(register, 1)[0];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return -1;
        }

        // Read multiple holding registers
        public void ReadHoldingRegisters(int register, int quantity)
        {
            if (modbusClient.Connected)
            {
                try
                {
                    readRegistersQueue.Enqueue(new KeyValuePair<int, int>(register, quantity));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        // Write holding register at register
        public void WriteHoldingRegister(int register, int value)
        {
            if (modbusClient.Connected)
            {
                writeRegisterQueue.Enqueue(new KeyValuePair<int, int>(register, value));
            }
        }

        public void WriteHoldingRegisters(int register, int[] value)
        {
            if (modbusClient.Connected)
            {
                writeRegistersQueue.Enqueue(new KeyValuePair<int, int[]>(register, value));
            }
        }
        #endregion


        #region Threaded Loop
        // This loop is responsible for all communication to and from the slide
        // All write and read calls are dequeued
        public void SerialQueueLoop()
        {
            while (true)
            {
                if (modbusClient.Connected)
                {
                    // Writing registers
                    KeyValuePair<int, bool> writeCoilItem;
                    bool writeCoilPop = writeCoilQueue.TryDequeue(out writeCoilItem);

                    KeyValuePair<int, int> writeRegisterItem;
                    bool writeRegisterPop = writeRegisterQueue.TryDequeue(out writeRegisterItem);

                    KeyValuePair<int, int[]> writeRegistersItem;
                    bool writeRegistersPop = writeRegistersQueue.TryDequeue(out writeRegistersItem);

                    //reading regs
                    KeyValuePair<int, int> readStatusItem;
                    bool readStatusPop = readRegistersQueue.TryDequeue(out readStatusItem);

                    // If pop was successful, write/read the kvp
                    try
                    {
                        if (writeCoilPop)
                        {
                            modbusClient.WriteSingleCoil(writeCoilItem.Key, writeCoilItem.Value);
                        }
                        if (writeRegisterPop)
                        {
                            modbusClient.WriteSingleRegister(writeRegisterItem.Key, writeRegisterItem.Value);
                        }
                        if (writeRegistersPop)
                        {
                            modbusClient.WriteMultipleRegisters(writeRegistersItem.Key, writeRegistersItem.Value);
                        }
                        if (readStatusPop)
                        {
                            int[] holdingRegisters = modbusClient.ReadHoldingRegisters(readStatusItem.Key, readStatusItem.Value);
                            state.ALMC = holdingRegisters[2]; // Byte 2 holds the Alarm Code
                            state.PNOW = CombineBytes(holdingRegisters[0], holdingRegisters[1]) * 0.01;     // Bytes 0 and 1 
                            state.VNOW = CombineBytes(holdingRegisters[10], holdingRegisters[11]) * 0.01;   // Bytes 10 and 11 are the velocity
                            state.CNOW = CombineBytes(holdingRegisters[12], holdingRegisters[13]);          // Bytes 12 and 13 are
                        }
                    } 
                    catch (Exception)
                    {
                        Console.WriteLine("Read loop error! Number of retries: " + modbusClient.NumberOfRetries);
                    }
                }
            }
        }

        public event EventHandler LimitExceeded;  // Delegate

        protected virtual void OnLimitExceeded(EventArgs e) // This method is called when the amp limit is exceeded
        {
            //if ProcessCompleted is not null then call delegate
            LimitExceeded?.Invoke(this, e);
        }

        private void CheckAmpLimit()
        {
            // If using the jog or inch buttons
            if (state.jogOrInch && state.SV)
            {
                // If jog/inching down & amp exceeds limit
                if ((state.jogDown || state.inchDown) && (state.VNOW != 0) && (state.CNOW > settings.ampDownLimit))
                {
                    // Move in negative direction slightly when limit is reached
                    RelativeMove(-4);

                    // Stop slide motion and turn off power
                    StopMotion();
                    SetPower(false);

                    // Call LimitExceeded event
                    OnLimitExceeded(EventArgs.Empty);
                }
                //when jog/inching up & amp exceeds limit
                if ((state.jogUp || state.inchUp) && (state.VNOW != 0) && (state.CNOW > settings.ampUpLimit))
                {
                    // Move in positive direction slightly when limit is reached
                    RelativeMove(4);

                    // Stop slide motion and turn off power
                    StopMotion();
                    SetPower(false);

                    // Call LimitExceeded event
                    OnLimitExceeded(EventArgs.Empty);
                }
            }

            // If not using the jog or inch buttons
            // To determine if the slide is moving in postive or negative direction we use > and < operators
            // When a crash happens, the VNOW can sporatically change; therefore, no RelativeMove operation is performed
            if (!state.jogOrInch && state.SV)
            {
                // If the slide is moving down
                if (state.VNOW > 0 && state.CNOW > settings.ampDownLimit)
                {
                    // Move in negative direction slightly when limit is reached
                    //RelativeMove(-4);

                    // Stop slide motion and turn off power
                    StopMotion();
                    SetPower(false);

                    // Call LimitExceeded event
                    OnLimitExceeded(EventArgs.Empty);
                }
                // If the slide is moving up
                if (state.VNOW < 0 && state.CNOW > settings.ampUpLimit)
                {
                    // Move in positive direction slightly when limit is reached
                    //RelativeMove(4);

                    // Stop slide motion and turn off power
                    StopMotion();
                    SetPower(false);

                    // Call LimitExceeded event
                    OnLimitExceeded(EventArgs.Empty);
                }
            }
        }

        readonly int readLoopDebounce = 50; // ms

        private void ReadLoop()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            while (true)
            {
                // Debounce
                if(stopwatch.ElapsedMilliseconds > readLoopDebounce)
                {
                    // Read registers in slide
                    ReadHoldingRegisters(0x9000, 14);
                    CheckAmpLimit();
                    stopwatch.Restart();
                }
            }
        }

        public void CloseThreads()
        {
            thread.Abort();
            readThread.Abort();
        }
        #endregion


        // Combine 2 bytes(hi) with 2 bytes (lo)
        public int CombineBytes(int highOrderBytes, int lowOrderBytes)
        {
            int result = ((highOrderBytes & 0xFFFF) << 16) | (lowOrderBytes & 0xFFFF);
            return result;
        }

    }
}