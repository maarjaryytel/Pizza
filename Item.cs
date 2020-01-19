using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Item
    {
        Pitsa pitsa;
        int quantity;

        public Item(Pitsa _pitsa, int _quantity)
        {
            pitsa = _pitsa;
            quantity = _quantity;
        }

        public void PrintItem()
        {
            Console.WriteLine($"Pitsa ID: {pitsa.Id} \n" +
                              $"Pitsa kogus: {quantity} \n" +
                              $"Pitsa tükihind: {pitsa.Price} €\n" +                             
                              $"Pitsa(de) maksumus kokku: {(Math.Round(CalculateItemTotal(), 2))} €\n");  
        }

        public double CalculateItemTotal()
        {
            return pitsa.Price * quantity;            
        }
    }
}
