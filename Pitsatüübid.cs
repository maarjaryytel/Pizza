using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
    enum Pitsatüübid
    {
        Americana,
        Bolognese,
        Hawai,
        Kebab,
        Peetri
    }
    class Pitsa
    {
        int id;
        Pitsatüübid pitsatüübid;
        double price;
        Ained ained;
        Taina_tüübid taina_tüübid;

        public Pitsa(int _id, Pitsatüübid _pitsatüübid, double _price, Ained _ained1, Ained _ained2, Ained _ained3, Ained _ained4, Taina_tüübid _taina_tüübid)
        {
            id = _id;
            pitsatüübid = _pitsatüübid;
            price = _price;
            ained = _ained1;
            ained = _ained2;
            ained = _ained3;
            ained = _ained4;
            taina_tüübid = _taina_tüübid;
        }

        public int Id
        {
            get { return id; }
        }

        public string Pitsatüübid
        {
            get { return pitsatüübid.ToString(); }
        }

        public double Price
        {
            get { return price; }
        }
                
        public string Taina_tüübid
        {
            get { return taina_tüübid.ToString(); }
        }
    }
}
