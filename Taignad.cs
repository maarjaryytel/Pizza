using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza
{
	enum Taina_tüübid
	{
		õhuketainas,
		pakstainas
	}

	class Taignad
	{
		int id;
		Taina_tüübid taina_tüübid;
		double price;		

		public Taignad(int _id,  Taina_tüübid _taina_tüübid, double _price)
		{
			id = _id;			
			taina_tüübid = _taina_tüübid;
			price = _price;
		}

		public int Id
		{
			get { return id; }
		}

		public string Taina_tüübid
		{
			get { return taina_tüübid.ToString(); }
		}

		public double Price
		{
			get { return price; }
			set
			{
				if (taina_tüübid.ToString() == "õhuketainas")
				{
					price = 1.20;
				}
				else
				{
					price = 1.50;
				}
			}
		}		
	}
}

