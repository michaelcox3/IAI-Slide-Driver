using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCONController
{
    internal interface Controller_Interface
    {
        /// <summary>
        /// Set the servo power
        /// </summary>
        /// <param name="power">True: On, False: Off</param>
        void SetPower(bool power);

        /// <summary>
        /// Reset any current alarms present in the axis. If any alarm cause has not been removed, the same alarm will be generated again.
        /// </summary>
        void AlarmReset();

        /// <summary>
        /// Command servo to home
        /// </summary>
        void Home();

        /// <summary>
        /// Perform an inch upward. Distance and speed are dependant on their corresponding parameters
        /// </summary>
        void InchUp();

        /// <summary>
        /// Perform an inch downward. Distance and speed are dependant on their corresponding parameters
        /// </summary>
        void InchDown();

        /// <summary>
        /// Begin jogging upwards
        /// </summary>
        void JogUpStart();

        /// <summary>
        /// Begin jogging downwards
        /// </summary>
        void JogDnStart();

        /// <summary>
        /// Stop jogging
        /// </summary>
        void JogStop();

        /// <summary>
        /// Perform an absolute move to a position
        /// Units: mm
        /// </summary>
        /// <param name="position">Position value (mm)</param>
        void AbsoluteMove(double position);

        /// <summary>
        /// Perform a move relative to the position in the axis 'State' object
        /// Units: mm
        /// </summary>
        /// <param name="distance">Distance relative to current state</param>
        void RelativeMove(double distance);

        /// <summary>
        /// Specify the moving speed for the axis (when not in safety speed mode)
        /// Units: mm/sec
        /// </summary>
        /// <param name="speed"></param>
        void SetSpeed(int speed);

        /// <summary>
        /// Specify the acceleration/decceleration rate of the axis
        /// Units: G
        /// </summary>
        /// <param name="accel"></param>
        void SetAccel(double accel);

        /// <summary>
        /// Request that the slide decelerate to a stop.
        /// </summary>
        void StopMotion();

        /// <summary>
        /// Requests the slide to pause all movement.
        /// If the pause command is transmitted during movement, the actuator decelerates and stops. 
        /// If the status is set back to normal again, the actuator resumes moving for the remaining distance. 
        /// As long as the pause command is being transmitted, all motor movement is inhibited.  
        /// If the alarm reset command bit is set while the actuator is paused, the remaining travel will be cancelled.  
        /// If this bit is set during home return, the movement command will be held if the actuator has not yet reversed 
        /// after contacting the mechanical end. If the actuator has already reversed after contacting the mechanical end, 
        /// home return will be repeated from the beginning. 
        /// </summary>
        /// <param name="pause">True: Pause, False: Unpause</param>
        void PauseMotion(bool pause);

        /// <summary>
        /// Brake control is linked to servo ON/OFF. The brake can be forcefully released even when the servo is ON.
        /// </summary>
        /// <param name="release">True: Brake forced release, False: Normal</param>
        void BreakRelease(bool breakRelease);

        /// <summary>
        /// This query enables/disables the speed specified by user parameter No. 35, “Safety speed.” 
        /// Enabling the safety speed in the MANU mode will limit the speeds of all movement commands. 
        /// </summary>
        /// <param name="enabled"></param>
        void SafetySpeed(bool safetyOn);
    }
}
