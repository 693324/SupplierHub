using System;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class RfxEvent
	{
		[Key]
<<<<<<< HEAD
		public int rfx_id { get; set; }

		[Required]
		public RFxType type { get; set; } 

		[Required]
		[StringLength(200)]
		public string? title { get; set; }
		
		public int category_id { get; set; }
		[ForeignKey(nameof(category_id))]

		public Category Category { get; set; }


		public int created_by { get; set; }
		[ForeignKey(nameof(created_by))]

		public virtual User? User { get; set; }


		[Required]
		public DateTime open_date { get; set; }

		[Required]
		public DateTime close_date { get; set; }

		[Required]
		[StringLength(20)]
		public RFxStatus status { get; set; }

		public bool IsDeleted { get; set; } = false;

		public Award Award { get; set; }
		public virtual ICollection<RFxLine> RFxLines { get; set; }
		public virtual ICollection<RFxInvite> RFxInvites { get; set; }
		public virtual ICollection<Bid> Bids { get; set; }


=======
		public long RfxID { get; set; }

		[Required, MaxLength(10)]
		public required string Type { get; set; }

		[Required, MaxLength(200)]
		public required string Title { get; set; }

		public long? CategoryID { get; set; }

		public long? CreatedBy { get; set; }

		public DateTime? OpenDate { get; set; }

		public DateTime? CloseDate { get; set; }

		[Required, MaxLength(30)]
		public required string Status { get; set; }

		[Required]
		public DateTime CreatedOn { get; set; }

		[Required]
		public DateTime UpdatedOn { get; set; }

		[Required]
		public bool IsDeleted { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f
	}
}