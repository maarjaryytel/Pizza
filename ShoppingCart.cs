using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class ShoppingCart
    {
        List<Item> shoppingCart;
        List<Item2> shoppingCart2;
        List<Item3> shoppingCart3;
        double total;

       public ShoppingCart()
        {
            shoppingCart = new List<Item>();
            shoppingCart2 = new List<Item2>();
            shoppingCart3 = new List<Item3>();
            total = 0;
        }

        public double Total
        {
            get { return total; }
        }

        public void AddToShoppingCart(Pitsa pitsa, int quantity)
        {
            Item newItem = new Item(pitsa, quantity);
            shoppingCart.Add(newItem);
        }

        public void AddToShoppingCart2(Ingredients ingredients, int quantity2)
        {
            Item2 newItem = new Item2(ingredients, quantity2);
            shoppingCart2.Add(newItem);
        }

        public void AddToShoppingCart3(Taignad taignad, int quantity3)
        {
            Item3 newItem = new Item3(taignad, quantity3);
            shoppingCart3.Add(newItem);
        }

        public void PrintShoppingCart()
        {
            foreach (Item item in shoppingCart)
            {
                item.PrintItem();
            }
            foreach (Item2 item in shoppingCart2)
            {
                item.PrintItem2();
            }
            foreach (Item3 item in shoppingCart3)
            {
                item.PrintItem3();
            }
        }

        public void PrintTotal()
        {
            foreach (Item item in shoppingCart)
            {
                total += item.CalculateItemTotal();
            }
            foreach (Item2 item in shoppingCart2)
            {
                total += item.CalculateItemTotal2();
            }
            foreach (Item3 item in shoppingCart3)
            {
                total += item.CalculateItemTotal3();
            }
        }        
    }
}
