using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Core.DataAccess
{
	public interface IEntityRepository<T> where T : class, new()
	{
		//T nesnesi ile yapılabilecek fonksiyonları buraya yazacağız.
	}
}
