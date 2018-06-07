using System;
using System.Collections.Generic;

namespace OOP_phone
{
    public class Galaxy: Phone, IRingable
    {
        public Galaxy(string vernum, int batpct, string carrier, string ringer) :base(vernum, batpct, carrier, ringer) 
        { }
        public string Ring()
        {
            return getRT();
        }
        public string Unlock()
        {
            return $"Galaxy {getVer()} Unlocked";
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"*****\nGalaxy {getVer()}\nBattery Percentage: {getBatt()}%\nCarrier: {getCarrier()}\nRing Tone: {getRT()}\n*****");
        }
    }
}