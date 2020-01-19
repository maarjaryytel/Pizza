using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Item2
    {
        Ingredients ingredients;
        int quantity2;

        public Item2(Ingredients _ingredients, int _quantity2)
        {
            ingredients = _ingredients;
            quantity2 = _quantity2;
        }

        public void PrintItem2()
        {
            Console.WriteLine($"Koostisosa ID: {ingredients.Id} \n" +
                              $"Koostisosa kogus: {quantity2} \n" +
                              $"Koostisosa tükihind: {ingredients.Price} €\n"+
                              $"Koostisosa(de) maksumus kokku: {(Math.Round(CalculateItemTotal2(), 2))} €\n");   
        }
        public double CalculateItemTotal2()
        {
            return ingredients.Price * quantity2;
        }
    }
}

