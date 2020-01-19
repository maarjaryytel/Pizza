using System;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Ladu currentlyInStock = new Ladu();
            Ladu currentlyInStock2 = new Ladu();
            Ladu currentlyInStock3 = new Ladu();

            ShoppingCart shoppingCart = new ShoppingCart();
            ShoppingCart shoppingCart2 = new ShoppingCart();
            ShoppingCart shoppingCart3 = new ShoppingCart();

            Console.WriteLine("Soovid menüüpitsat või ise pitsa kokku panna?");
            Console.WriteLine("Menüüpitsa saamiseks vali JAH," +
                             " ise pitsa kokku panemiseks vali EI: " +
                             " jah /ei \n");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "jah")
            {
                Console.WriteLine("\n");
                AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                AddItemsToShoppingCart2(currentlyInStock2, shoppingCart2);
                LisaKinnitaLahku(currentlyInStock, shoppingCart, currentlyInStock2, shoppingCart2);
                MenüüpitsaOstukorviKuvamine(shoppingCart, shoppingCart2);               
            }
            else
            {
                Console.WriteLine("\nVali esmalt pitsale taigen: \n");
                currentlyInStock3.TaignadPrintInStock();
                AddItemsToShoppingCart3(currentlyInStock3, shoppingCart3);
                AddItemsToShoppingCart2(currentlyInStock2, shoppingCart2);
                LisaKinnitaLahku(currentlyInStock, shoppingCart, currentlyInStock2, shoppingCart2);
                IsetehtudPitsaOstukorviKuvamine(shoppingCart2, shoppingCart3);
            }                        
        }

        public static void AddItemsToShoppingCart(Ladu currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Meie menüüst leiate alljärgnevad pitsad: \n");
            currentlyInStock.PitsaPrintInStock();

            Console.Write("Sisesta soovitud pitsa ID number vahemikus 1-10:  ");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("Sisesta soovitud pitsade arv: ");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Pitsa pitsaToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(pitsaToAdd, quantity);
            shoppingCart.PrintShoppingCart();
        }

        public static void AddItemsToShoppingCart2(Ladu currentlyInStock2, ShoppingCart shoppingCart2)
        {
            Console.WriteLine("Meie valikust leiate oma pitsale alljärgnevad täiendavad koostisosad: \n");
            currentlyInStock2.AinedPrintInStock();

            Console.WriteLine("Soovid oma pitsale täiendavaid koostisosi: jah /ei");
            string userInput2 = Console.ReadLine().ToLower();
            {
                if (userInput2 == "ei")
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("\nSisesta soovitud koostisosa ID number vahemikus 11-25: \n");
                    int productID2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.Write("Mitut koostisosa soovid? Sisesta vastav number: ");
                    int quantity2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Ingredients ingredientsToAdd = currentlyInStock2.GetFromStock2(productID2);
                    shoppingCart2.AddToShoppingCart2(ingredientsToAdd, quantity2);
                    shoppingCart2.PrintShoppingCart();
                }
            }           
        }

        public static void AddItemsToShoppingCart3(Ladu currentlyInStock3, ShoppingCart shoppingCart3)
        {
            Console.Write("Sisesta soovitud taigna ID number vahemikus 26-27:  \n");
            int productID3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.Write("Mitut taigent soovid? Sisesta vastav number: ");
            int quantity3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Taignad taignadToAdd = currentlyInStock3.GetFromStock3(productID3);
            shoppingCart3.AddToShoppingCart3(taignadToAdd, quantity3);
            shoppingCart3.PrintShoppingCart();
        }

        public static void MenüüpitsaOstukorviKuvamine(ShoppingCart shoppingCart, ShoppingCart shoppingCart2)
        {
            Console.WriteLine("Sinu ostukorv on järgmine: \n");
            shoppingCart.PrintShoppingCart();
            shoppingCart2.PrintShoppingCart();

            shoppingCart.PrintTotal();
            shoppingCart2.PrintTotal();
            Console.WriteLine($"Ostukorvis oleva(te) pitsa(de) maksumus kokku: {(Math.Round(shoppingCart.Total, 2))} €");
            Console.WriteLine($"Ostukorvis oleva(te) koostisosa(de) maksumus kokku: {(Math.Round(shoppingCart2.Total, 2))} €");
            Console.WriteLine($"Ostukorvi kogumaksumus: {(Math.Round(shoppingCart.Total + shoppingCart2.Total,2))} €");           
        }

        public static void IsetehtudPitsaOstukorviKuvamine(ShoppingCart shoppingCart2, ShoppingCart shoppingCart3)
        {
            Console.WriteLine("Sinu ostukorv on järgmine: \n");
            shoppingCart2.PrintShoppingCart();
            shoppingCart3.PrintShoppingCart();

            shoppingCart2.PrintTotal();
            shoppingCart3.PrintTotal();
            Console.WriteLine($"Ostukorvis oleva(te) koostisosa(de) maksumus kokku: {(Math.Round(shoppingCart2.Total,2))} €");
            Console.WriteLine($"Ostukorvis oleva(te) taigna(te) maksumus kokku: {(Math.Round(shoppingCart3.Total, 2))} €");
            Console.WriteLine($"Ostukorvi kogumaksumus: {(Math.Round(shoppingCart2.Total + shoppingCart3.Total, 2))} €");                        
        }

        public static void LisaKinnitaLahku(Ladu currentlyInStock, ShoppingCart shoppingCart, Ladu currentlyInStock2, ShoppingCart shoppingCart2)
        {
            while (true)
            {
                Console.Write("lisa /kinnita /lahku: \n");
                string userInput3 = Console.ReadLine().ToLower();

                if (userInput3 == "lisa")
                {
                    Console.WriteLine("\nSoovid lisada pitsat või koostisosa: pitsa / koostisosa?\n");
                    string userInput4 = Console.ReadLine().ToLower();

                    if (userInput4 == "pitsa")
                    {
                        Console.WriteLine("\n");
                        AddItemsToShoppingCart(currentlyInStock, shoppingCart);
                    }
                    else if (userInput4 == "koostisosa")
                    {
                        Console.WriteLine("\n");
                        AddItemsToShoppingCart2(currentlyInStock2, shoppingCart2);
                    }
                    else
                    {
                        Console.WriteLine("Vali: pitsa / koostisosa");
                    }
                }

                else if (userInput3 == "kinnita")
                {
                    Console.WriteLine("\n");
                    break;
                }

                else if (userInput3 == "lahku")
                {
                    Console.WriteLine("\nKülastage meid jälle!");
                    Environment.Exit(0);                      
                }

                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
