using System;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class Bid
	{
		[Key]
<<<<<<< HEAD
		public int bid_id { get; set; }

		[Required]
		public int rfx_id { get; set; }
		[ForeignKey("rfx_id")]
		public virtual RFxEvent RFxEvent { get; set; }

		public int supplier_id { get; set; }
		[ForeignKey(nameof(supplier_id))]
=======
		public long BidID { get; set; }

		[Required]
		public long RfxID { get; set; }

		[Required]
		public long SupplierID { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f

		public DateTime? BidDate { get; set; }

<<<<<<< HEAD
		public DateTime bid_date { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal total_value { get; set; }

		[StringLength(3)]
		public string currency { get; set; } 

		[StringLength(20)]
		public BidStatus status { get; set; }
=======
		public decimal? TotalValue { get; set; }

		[MaxLength(10)]
		public string? Currency { get; set; }

		[Required]
		public bool IsDeleted { get; set; }

		[Required, MaxLength(30)]
		public required string Status { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f

		[Required]
		public DateTime CreatedOn { get; set; }

		[Required]
		public DateTime UpdatedOn { get; set; }
	}
}