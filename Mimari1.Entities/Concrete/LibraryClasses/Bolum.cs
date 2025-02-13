using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mimari1.Entities.Concrete.LibraryClasses
{
    public class Bolum :BaseClasses.BaseObject
    {
		[Required]
		[StringLength(20)]
		[DisplayName("Bölüm Adı")]
		public string Tanim { get; set; }
		public int FakulteId { get; set; }
		public Fakulte Fakulte { get; set; }
	}
}
