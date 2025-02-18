using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Entities.Concrete.LibraryClasses
{
    public class Ogretmen : BaseClasses.BaseObject
    {

		public Ogretmen()
		{
			GirisTarihi = new DateTime();
		}
		public string Ad { get; set; }

		public string Soyad { get; set; }

		public string TamIsim => $"{Ad} {Soyad}";

		public string DanismanNo { get; set; }

		public DateTime GirisTarihi { get; set; }

	}
}
