using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProektMVC.models
{
    public class Model   
    {
        //uzdavam propertita i fildove
        private double p1;

        public double P1
        {
            get { return p1; }
            set { p1 = value; }
        }
        private double p2;

        public double P2
        {
            get { return p2; }
            set { p2 = value; }
        }
        private int[] numbers;

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        //uzdava 2 kontruktora . 1 prazen i 1 pulen
        public Model()
        {

        }
        public Model(double p1, double p2, int[] numbers)
        {
            this.P1 = p1;
            this.P2 = p2;
            this.Numbers = numbers;
        }
        //suzdavam metod za izchilqvane na procentite prosti chisla
        public double CalculateP1()
        {
            int primeCount = 0;

            for (int i = 0; i < this.Numbers.Length; i++)
            {
                bool isPrime = true;
                if (numbers[i] <= 1) isPrime = false;
                else
                {
                    for (int j = 2; j <= Math.Sqrt(numbers[i]); j++)
                    {
                        if (numbers[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                }

                if (isPrime)
                {
                    primeCount++;
                }
            }
            return (double)primeCount / this.Numbers.Length * 100;
        }
        //neproti chila
        public double CalculateP2()
        {
            return (double)100 - CalculateP1();
        }
    }
}
