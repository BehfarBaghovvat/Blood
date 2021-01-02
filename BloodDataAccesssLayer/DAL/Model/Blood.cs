using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace DAL.Model
{
	public class Blood
	{
		[Key]
		public int BloodID { get; set; }
		[MaxLength(50)]
		public string BloodSerial { get; set; }
		[MaxLength(50)]
		public string BloodGorup { get; set; }
		[MaxLength(50)]
		public string Section { get; set; }
		public string RegisterDate { get; set; }
		public string EditDate { get; set; }



	}
}
