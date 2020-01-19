using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Item3
    {
        Taignad taignad;
        int quantity3;

        public Item3(Taignad _taignad, int _quantity3)
        {
            taignad = _taignad;
            quantity3 = _quantity3;
        }

        public void PrintItem3()
        {
            Console.WriteLine($"Pitsapõhja ID: {taignad.Id} \n" +
                              $"Pitsapõhja kogus: {quantity3} \n" +
                              $"Pitsapõhja tükihind: {taignad.Price} €\n" +
                              $"Pitsapõhja(de) maksumus kokku: {(Math.Round(CalculateItemTotal3(), 2))} € \n");            
        }

        public double CalculateItemTotal3()
        {
            return taignad.Price * quantity3;
        }
    }
}

