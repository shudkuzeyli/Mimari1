using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Entities.Concrete.LibraryClasses
{
	public class Fakulte : BaseClasses.BaseObject
	{
		[Required]
		[StringLength(20)]
		[DisplayName("Fakülte Adı")]
		public string Tanim { get; set; }
	}
}
