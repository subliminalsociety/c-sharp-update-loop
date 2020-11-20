using System;
using System.Diagnostics;

namespace APP
{
    public class UpdateHandler
    {
        Stopwatch Stopwatch_Instance = new Stopwatch();
        private int refresh_rate = 16;
        private bool program_is_running = true;
        private int number_of_cycles = 0;


        public UpdateHandler()
        {
        }
        public UpdateHandler(int New_Refresh_Rate)
        {
            refresh_rate = New_Refresh_Rate;
        } 


        public void Start()
        {
            InitializeLoop();
        }
        public void Update()
        {
            number_of_cycles++;

            Console.WriteLine(number_of_cycles);
        }
        public void Stop()
        {
            program_is_running = false;
        }


        internal void InitializeLoop()
        {
            Stopwatch_Instance.Start();

            while (program_is_running)
            {
                if (Stopwatch_Instance.ElapsedMilliseconds >= refresh_rate)
                {
                    Update();

                    Stopwatch_Instance.Restart();
                }
            }
        }

    }
}
