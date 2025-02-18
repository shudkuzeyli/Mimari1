using Mimari1.Entities.Concrete.LibraryClasses;

namespace Mimari1.Business.Abstract.Services
{
	public interface IOgrenciService : IGenericService<Ogrenci>
	{
		//Generic Repo nun ortak olmayan özelliklerinin/fonksiyonlarının tanımlandığı yer
		T GetParentInfo<T>(int id);
	}
}

//Ogretmen(Isım, Soyisim, TamIsim, DanismanNo, GirisTarihi)