using System;
using System.Collections.Generic;

namespace OOP_phone
{
    public class HTC: Phone, IRingable
    {
        public HTC(string vernum, int batpct, string carrier, string ringer) :base(vernum, batpct, carrier, ringer) 
        { }
        public string Ring()
        {
            return getRT();
        }
        public string Unlock()
        {
            return $"HTC {getVer()} Unlocked";
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine($"*****\nHTC {getVer()}\nBattery Percentage: {getBatt()}%\nCarrier: {getCarrier()}\nRing Tone: {getRT()}\n*****\n");
        }
    }
}