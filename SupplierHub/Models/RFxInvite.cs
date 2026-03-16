using System;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class RfxInvite
	{
		[Key]
<<<<<<< HEAD
		public int invite_id { get; set; }

		[Required]
		public int rfx_id { get; set; }
		[ForeignKey("rfx_id")]
		public virtual RFxEvent RFxEvent { get; set; }

		public int supplier_id { get; set; }
		[ForeignKey(nameof(supplier_id))]  
		public virtual Supplier Supplier { get; set; }
=======
		public long InviteID { get; set; }

		[Required]
		public long RfxID { get; set; }

		[Required]
		public long SupplierID { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f

		public DateTime? InvitedDate { get; set; }

<<<<<<< HEAD
		public DateTime invited_date { get; set; } = DateTime.Now;

		[StringLength(20)]
		public InviteStatus status { get; set; }
=======
		[Required, MaxLength(30)]
		public required string Status { get; set; }

		[Required]
		public bool IsDeleted { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f

		[Required]
		public DateTime CreatedOn { get; set; }

		[Required]
		public DateTime UpdatedOn { get; set; }
	}
}