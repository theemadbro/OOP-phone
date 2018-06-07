using System;

namespace OOP_phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("S8", 97, "Verizon 'STEAL THE INTERNET' Wireless", "vrrr vrrrrrr");
            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            HTC m9 = new HTC("One M9", 30, "AT&T", "blililililee blililililiee");
            m9.DisplayInfo();
            System.Console.WriteLine(m9.Ring());
            System.Console.WriteLine(m9.Unlock());

        }
    }
}
