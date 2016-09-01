using Windows.ApplicationModel.Background;
using Adafruit.IoT.Devices;
using Adafruit.IoT.Motors;
// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace Blinky
{
    public sealed class StartupTask : IBackgroundTask
    {   
        BackgroundTaskDeferral deferral;
        
        private bool _timerEnabled;
        
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            deferral = taskInstance.GetDeferral();

            var mh = new MotorHat2348(0x60);  //this is I2C address?

            var motor1 = mh.CreateDCMotor(1);
            motor1.SetSpeed(30);
            motor1.Run(Direction.Forward);

            var motor2 = mh.CreateDCMotor(2);
            motor2.SetSpeed(30);
            motor2.Run(Direction.Forward);

            //var motor3 = mh.CreateDCMotor(3);
            //motor3.SetSpeed(30);
            //motor3.Run(Direction.Forward);

            //var motor4 = mh.CreateDCMotor(4);
            //motor4.SetSpeed(30);
            //motor4.Run(Direction.Forward);


            var pwm = mh.CreatePwm(1);
            pwm.Start();


            var x = 9;

            pwm.Stop();


            //var wait = Task.Delay(5000);
            //while (!wait.IsCompleted)
            //{
            //}
            //motor1.SetSpeed(0);
            //motor1.Dispose();

        }
        
    }
}
