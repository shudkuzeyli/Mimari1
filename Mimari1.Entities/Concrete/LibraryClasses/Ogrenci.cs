namespace Mimari1.Entities.Concrete.LibraryClasses
{
	public class Ogrenci : BaseClasses.BaseObject
	{
		public Ogrenci()
		{
			KayitTarihi=new DateTime();
		}
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string TamIsim => $"{Ad} {Soyad}";
		public string OgrenciNo { get; set; }
		public DateTime KayitTarihi { get; set; }


	}
}

//Fakulte, Bolum, BolumOgrenci tabloları oluşturulacak.
