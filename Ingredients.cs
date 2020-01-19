using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    enum Ained
    {
        hakkliha,
        juust,
        krevetid,
        lõhe,
        tomat,
        salaami,
        kana,
        oliivid,
        artishokid,
        paprika,
        ananass,
        jalapeno,
        sibul,
        kebab,
        pepperoni
    }
    class Ingredients
    {
        int id;        
        Ained ained;
        double price;

        public Ingredients(int _id,  Ained _ained, double _price)
        {
            id = _id;            
            ained = _ained;
            price = _price;
        }

        public int Id
        {
            get { return id; }
        }              

        public string Ained
        {
            get { return ained.ToString(); }
        }

        public double Price
        {
            get { return price; }            
        }
    }
}

