# <IAI-Slide-Driver>

## Description

The IAI Slide Driver aims to provide an intuitive and simple interface that controls PCON or SCON slides distributed by IAI America.\
- Implements basic control functions such as absolute move, incremental move, jogging and inching.\
- Provides the user access to safety parameters such as amp limits in either direction.\
- Displays status information such as position, speed, and motor draw.\
- Handles errors thrown by the slide and is designed to halt when an error is detected.\
- Automatically populates the COM Port drop down menu with any COM ports detected by windows.\
- Preset section where user can create a preset of the current position and return to the position through the preset.\

The project introduced me to incremental encoders. I learned that in order to perform an absolute move, the slide must be homed first.
Additionally, the project tested my ability to convert between hexadecimal and decimal formats and working with registers.
Finally, I had to design queue loop for the serial communication to ensure that a read command and write command could never happen at the same time which would cause the slide to error.

## Usage

The following control commands are implemented:
    - Connect/Disconnect to COM Port
    - Set Servo Power\
    - Reset Alarm\
    - Home\
    - Inch Up\
    - Inch Down\
    - Jog Up\
    - Jog Down\
    - Stop Motion\
    - Absolute Move\
    
Provide instructions and examples for use. Include screenshots as needed.

To add a screenshot, create an `assets/images` folder in your repository and upload your screenshot to it. Then, using the relative filepath, add it to your README using the following syntax:

    ```md
    ![alt text](assets/images/screenshot.png)
    ```

## Credits
This project uses the "EasyModbusDLL" library from the "EasyModbusTCP.NET" GitHub repository. 
Copyright (c) 2018-2020 Rossmann-Engineering. For more information, see [https://github.com/rossmann-engineering/EasyModbusTCP.NET](https://github.com/rossmann-engineering/EasyModbusTCP.NET).


## License

Copyrighted under the GNU General Public License - http://www.gnu.org/licenses/

The last section of a high-quality README file is the license. This lets other developers know what they can and cannot do with your project. If you need help choosing a license, refer to [https://choosealicense.com/](https://choosealicense.com/).

---

🏆 The previous sections are the bare minimum, and your project will ultimately determine the content of this document. You might also want to consider adding the following sections.

## Badges

![badmath](https://img.shields.io/github/languages/top/lernantino/badmath)

Badges aren't necessary, per se, but they demonstrate street cred. Badges let other developers know that you know what you're doing. Check out the badges hosted by [shields.io](https://shields.io/). You may not understand what they all represent now, but you will in time.

## Features

If your project has a lot of features, list them here.

## How to Contribute

If you created an application or package and would like other developers to contribute it, you can include guidelines for how to do so. The [Contributor Covenant](https://www.contributor-covenant.org/) is an industry standard, but you can always write your own if you'd prefer.

## Tests

Go the extra mile and write tests for your application. Then provide examples on how to run them here.
