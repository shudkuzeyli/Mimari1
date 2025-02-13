namespace Mimari1.Entities.Concrete.LibraryClasses
{
    public class BolumOgrenci: BaseClasses.BaseObject
	{
		public int OgrenciId { get; set; }

		public Ogrenci Ogrenci { get; set; }

		public int BolumId { get; set; }

		public Bolum Bolum { get; set; }
	}
}
