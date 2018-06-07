using System;
using System.Collections.Generic;

namespace OOP_phone
{
    public abstract class Phone
    {
        private string _versionNumber { get; set; }
        private int _batteryPercentage { get; set; }
        private string _carrier { get; set; }
        private string _ringTone { get; set; }
        public Phone(string vernum, int batpct, string carrier, string ringer)
        {
            _versionNumber = vernum;
            _batteryPercentage = batpct;
            _carrier = carrier;
            _ringTone = ringer;
        }
        protected string getVer()
        {
            return _versionNumber;
        }
        protected int getBatt()
        {
            return _batteryPercentage;
        }
        protected string getCarrier()
        {
            return _carrier;
        }       
        protected string getRT()
        {
            return _ringTone;
        }
        public abstract void DisplayInfo();

    }
    
    public interface IRingable
    {
        string Ring();
        string Unlock();
    }
}