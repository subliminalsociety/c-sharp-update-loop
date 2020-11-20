using System;
using System.Diagnostics;

namespace APP
{
    public class UpdateHandler_WithComments
    {
        //The `System.Diagnostics.Stopwatch` is what I am using.
        Stopwatch Stopwatch_Instance = new Stopwatch();

        //The refresh-rate is how many milliseconds each update-tick takes.
        //I got 16 from a standard 1000ms (1 second) / 60fps (standard framerate) calculation.
        private int refresh_rate = 16;

        //This is the boolean that controls whether the loop continues or not.
        private bool program_is_running = true;

        //This is an iterator that increases by 1 everytime Update is called. So once every refresh-rate elapse.
        private int number_of_cycles = 0;


        //Here is a default, parameterless constructor.
        public UpdateHandler_WithComments()
        {
        }
        //Here is a constructor where you can specify a custom refresh rate.
        public UpdateHandler_WithComments(int New_Refresh_Rate)
        {
            //Assign custom refresh rate to this class's refresh rate variable
            refresh_rate = New_Refresh_Rate;
        } 

        //This is the method that starts the loop- must be called externally.
        //The alternative is to add this function into the body of the constructor,
        //that way the loop begins as soon as this class is instantiated.
        public void Start()
        {
            //This starts the loop
            InitializeLoop();
        }
        
        //This is the method that gets called once every frame. All your update functionality goes in here.
        public void Update()
        {
            //This iterates through the number of cycles
            number_of_cycles++;

            //This prints out how many frames have elapsed thus so far
            Console.WriteLine(number_of_cycles);
        }

        //This is the method that gets called to turn the loop off, and stop updates from happening
        public void Stop()
        {
            //Set the booleaj to false, as the update-loop is dependent on this to keep running.
            program_is_running = false;
        }

        //This is the logic behind update.
        internal void InitializeLoop()
        {
            //Here we tell our instance of the stopwatch class to Start it's timer.
            Stopwatch_Instance.Start();

            //While our boolean is equal to true, it will loop.
            while (program_is_running)
            {
                //If the stopwatch's counter is equal to (or greater than, as a safety net) to the refresh rate...
                if (Stopwatch_Instance.ElapsedMilliseconds >= refresh_rate)
                {
                    //Call update
                    Update();

                    //Restart the stopwatch's counter to zero, to set it up to catch another update.
                    Stopwatch_Instance.Restart();
                }
            }
        }

    }
}
