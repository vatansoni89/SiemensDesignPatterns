using System;
using System.Collections.Generic;
using System.Text;

namespace MyCar
{
    class Seatbelt
    {
        private readonly Alarm _alarm;
        public bool IsLocked { get; set; } = false;
        public Seatbelt(CarSpeedSimulator speedSimulator, Alarm alarm)
        {
            _alarm = alarm;
            speedSimulator.SpeedChanged += OnSpeedChanged;
        }

        private void OnSpeedChanged(int speed)
        {
            if (speed > 20 && IsLocked == false)
            {
                _alarm.RaiseAlarm();
            }
        }

        public void Locked()
        {
            IsLocked = true;
            Console.Write("Locked.");
        }
        public void Unlocked()
        {
            Console.Write("Unlocked.");
        }
    }
}
