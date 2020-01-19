using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    class Ladu
    {
        List<Pitsa> PitsadLaos;
        List<Ingredients> AinedLaos;
        List<Taignad> TaignadLaos;

        public Ladu()
        {
            PitsadLaos = new List<Pitsa>();
            Pitsa Americana = new Pitsa(1, Pitsatüübid.Americana, 4.30, Ained.juust, Ained.salaami, Ained.ananass, Ained.oliivid, Taina_tüübid.õhuketainas);
            PitsadLaos.Add(Americana);
            Pitsa Americana2 = new Pitsa(2, Pitsatüübid.Americana, 5.30, Ained.juust, Ained.salaami, Ained.ananass, Ained.oliivid, Taina_tüübid.pakstainas);
            PitsadLaos.Add(Americana2);
            Pitsa Bolognese = new Pitsa(3, Pitsatüübid.Bolognese, 4.50, Ained.juust, Ained.hakkliha, Ained.jalapeno, Ained.paprika, Taina_tüübid.õhuketainas);
            PitsadLaos.Add(Bolognese);
            Pitsa Bolognese2 = new Pitsa(4, Pitsatüübid.Bolognese, 5.50, Ained.juust, Ained.hakkliha, Ained.jalapeno, Ained.paprika, Taina_tüübid.pakstainas);
            PitsadLaos.Add(Bolognese2);
            Pitsa Hawai = new Pitsa(5, Pitsatüübid.Hawai, 4.10, Ained.juust, Ained.kana, Ained.sibul, Ained.paprika, Taina_tüübid.õhuketainas);
            PitsadLaos.Add(Hawai);
            Pitsa Hawai2 = new Pitsa(6, Pitsatüübid.Hawai, 5.10, Ained.juust, Ained.kana, Ained.sibul, Ained.paprika, Taina_tüübid.pakstainas);
            PitsadLaos.Add(Hawai2);
            Pitsa Kebab = new Pitsa(7, Pitsatüübid.Kebab, 4.05, Ained.juust, Ained.sibul, Ained.jalapeno, Ained.kebab, Taina_tüübid.õhuketainas);
            PitsadLaos.Add(Kebab);
            Pitsa Kebab2 = new Pitsa(8, Pitsatüübid.Kebab, 5.05, Ained.juust, Ained.sibul, Ained.jalapeno, Ained.kebab, Taina_tüübid.pakstainas);
            PitsadLaos.Add(Kebab2);
            Pitsa Peetri = new Pitsa(9, Pitsatüübid.Peetri, 3.90, Ained.juust, Ained.hakkliha, Ained.pepperoni, Ained.paprika, Taina_tüübid.õhuketainas);
            PitsadLaos.Add(Peetri);
            Pitsa Peetri2 = new Pitsa(10, Pitsatüübid.Peetri, 4.90, Ained.juust, Ained.hakkliha, Ained.pepperoni, Ained.paprika, Taina_tüübid.pakstainas);
            PitsadLaos.Add(Peetri2);

            AinedLaos = new List<Ingredients>();
            Ingredients hakkliha = new Ingredients(11, Ained.hakkliha, 1.10);
            AinedLaos.Add(hakkliha);
            Ingredients juust = new Ingredients(12, Ained.juust, 1.20);
            AinedLaos.Add(juust);
            Ingredients krevetid = new Ingredients(13, Ained.krevetid, 1.00);
            AinedLaos.Add(krevetid);
            Ingredients lõhe = new Ingredients(14, Ained.lõhe, 1.25);
            AinedLaos.Add(lõhe);
            Ingredients tomat = new Ingredients(15, Ained.tomat, 1.35);
            AinedLaos.Add(tomat);
            Ingredients salaami = new Ingredients(16, Ained.salaami, 1.40);
            AinedLaos.Add(salaami);
            Ingredients kana = new Ingredients(17, Ained.kana, 1.50);
            AinedLaos.Add(kana);
            Ingredients oliivid = new Ingredients(18, Ained.oliivid, 1.05);
            AinedLaos.Add(oliivid);
            Ingredients artishokid = new Ingredients(19, Ained.artishokid, 1.20);
            AinedLaos.Add(artishokid);
            Ingredients paprika = new Ingredients(20, Ained.paprika, 1.10);
            AinedLaos.Add(paprika);
            Ingredients ananass = new Ingredients(21, Ained.ananass, 0.95);
            AinedLaos.Add(ananass);
            Ingredients jalapeno = new Ingredients(22, Ained.jalapeno, 1.05);
            AinedLaos.Add(jalapeno);
            Ingredients sibul = new Ingredients(23, Ained.sibul, 0.75);
            AinedLaos.Add(sibul);
            Ingredients kebab = new Ingredients(24, Ained.kebab, 1.20);
            AinedLaos.Add(kebab);
            Ingredients pepperoni = new Ingredients(25, Ained.pepperoni, 1.30);
            AinedLaos.Add(pepperoni);

            TaignadLaos = new List<Taignad>();
            Taignad õhuketainas = new Taignad(26, Taina_tüübid.õhuketainas,  1.20);
            TaignadLaos.Add(õhuketainas);
            Taignad pakstainas = new Taignad(27, Taina_tüübid.pakstainas, 1.50);
            TaignadLaos.Add(pakstainas);
        }

        public void PitsaPrintInStock()
        {
            foreach (Pitsa pitsa in PitsadLaos)
            {
                Console.WriteLine($"ID: {pitsa.Id}");
                Console.WriteLine($"Pitsa nimi: {pitsa.Pitsatüübid}");
                Console.WriteLine($"Hind: {pitsa.Price} €");
                Console.WriteLine($"Pitsapõhi: {pitsa.Taina_tüübid}");

                if (pitsa.Pitsatüübid == "Americana" || pitsa.Pitsatüübid == "Americana 2")
                {
                    Console.WriteLine("Koostisained: {0}, {1}, {2}, {3}", Ained.juust, Ained.salaami, Ained.ananass, Ained.oliivid);
                }

                if (pitsa.Pitsatüübid == "Bolognese" || pitsa.Pitsatüübid == "Bolognese 2")
                {
                    Console.WriteLine("Koostisained: {0}, {1}, {2}, {3}", Ained.juust, Ained.hakkliha, Ained.jalapeno, Ained.paprika);
                }

                if (pitsa.Pitsatüübid == "Hawai" || pitsa.Pitsatüübid == "Hawai 2")
                {
                    Console.WriteLine("Koostisained: {0}, {1}, {2}, {3}", Ained.juust, Ained.kana, Ained.sibul, Ained.paprika);
                }

                if (pitsa.Pitsatüübid == "Kebab" || pitsa.Pitsatüübid == "Kebab 2")
                {
                    Console.WriteLine("Koostisained: {0}, {1}, {2}, {3}", Ained.juust, Ained.sibul, Ained.jalapeno, Ained.kebab);
                }

                if (pitsa.Pitsatüübid == "Peetri" || pitsa.Pitsatüübid == "Peetri 2")
                {
                    Console.WriteLine("Koostisained: {0}, {1}, {2}, {3}", Ained.juust, Ained.hakkliha, Ained.pepperoni, Ained.paprika);
                }

                Console.WriteLine();
            }
        }

        public void AinedPrintInStock()
        {
            foreach (Ingredients ingredients in AinedLaos)
            {
                Console.WriteLine($"ID: {ingredients.Id}");
                Console.WriteLine($"Koostisosa nimetus: {ingredients.Ained}");
                Console.WriteLine($"Koostisosa hind: {ingredients.Price} €");
                Console.WriteLine();
            }
        }

        public void TaignadPrintInStock()
        {
            foreach (Taignad taignad in TaignadLaos)
            {
                Console.WriteLine($"ID: {taignad.Id}");
                Console.WriteLine($"Pitsapõhja tüüp: {taignad.Taina_tüübid}");
                Console.WriteLine($"Pitsapõhja hind: {taignad.Price} €");
                Console.WriteLine();
            }
        }

        public Pitsa GetFromStock(int id)
        {
            return PitsadLaos[id - 1];
        }

        public Ingredients GetFromStock2(int id)
        {
            return AinedLaos[id - 11];
        }

        public Taignad GetFromStock3(int id)
        {
            return TaignadLaos[id - 26];
        }
    }
}
