using System;
using System.Windows.Forms;

namespace App
{
    public class Pomodoro
    {
        private event EventHandler begin;
        public event EventHandler Begin { add => begin += value; remove => begin -= value; }
        private event EventHandler count;
        public event EventHandler Count { add => count += value; remove => count -= value; }
        private event EventHandler done;
        public event EventHandler Finish { add => done += value; remove => done -= value; }

        private bool isWorkState;
        public bool IsWorkState { get => isWorkState; set => isWorkState = value; }
        private int workTime;
        public int WorkTime { get => workTime; set => workTime = value; }
        private int restTime;
        public int RestTime { get => restTime; set => restTime = value; }
        private int counter;
        public int Counter { get => counter; set => counter = value; }

        private Timer timer;

        public Pomodoro()
        {
            isWorkState = true;
            workTime = 10;
            restTime = 5 * 60;
            counter = workTime;
            timer = new Timer() { Interval = 1000};
        }

        public void Start()
        {            
            timer.Tick += Run;
            timer.Enabled = true;
            begin?.Invoke(null, null);
        }

        private void Run(object obj, EventArgs args)
        {
            counter--;
            count?.Invoke(null, null);
            if (counter == 0) End();                                        
        }

        private void End()
        {
            timer.Tick -= Run;
            timer.Enabled = false;
            isWorkState = !isWorkState;
            counter = isWorkState ? workTime : restTime;
            done?.Invoke(null, null);
        }

        public string Time()
        {
            int minutes = counter / 60;
            int seconds = counter % 60;
            string minutesString = (minutes < 10) ? '0' + minutes.ToString() : minutes.ToString();
            string secondsString = ( seconds < 10) ? '0' + seconds.ToString() : seconds.ToString();
            return minutesString + ':' + secondsString;
        }

        public void Reset(int work, int rest)
        {
            timer.Tick -= Run;
            timer.Enabled = false;
            isWorkState = true;
            workTime = work;
            restTime = rest;
            counter = workTime;
            done?.Invoke(null, null);
        }
    }
}
