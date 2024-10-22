using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMVC.views
{
    public class Display
    {
        //uzdavam properti
        public double P1 { get; set; }
        public double P2 { get; set; }
        public int[] Numbers { get; set; }

        //dva metoda za input i aoutput
        public void Input()
        {
            Console.WriteLine("Vuvedi n ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                this.Numbers[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Output()
        {
            Console.WriteLine($"prosti chisla {this.P1}");
            Console.WriteLine($"neproti chisla {this.P2}");
        }
    }
}
