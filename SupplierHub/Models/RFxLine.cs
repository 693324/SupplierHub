using System;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class RfxLine
	{
		[Key]
<<<<<<< HEAD
		public int rfx_line_id { get; set; }

		[Required]
		public int rfx_id { get; set; }
		[ForeignKey("rfx_id")]
		public virtual RFxEvent RFxEvent { get; set; }

		public int item_id { get; set; }
		[ForeignKey(nameof(item_id))]
		public virtual Item Item { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal qty { get; set; }

		[Required]
		[StringLength(10)]
		public UOM uom { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? target_price { get; set; }

		public string notes { get; set; }
=======
		public long RfxLineID { get; set; }

		[Required]
		public long RfxID { get; set; }

		public long? ItemID { get; set; }

		public decimal? Qty { get; set; }

		[MaxLength(30)]
		public string? Uom { get; set; }

		public decimal? TargetPrice { get; set; }

		[MaxLength(500)]
		public string? Notes { get; set; }
>>>>>>> f5b24b19b20cc4f606a8ea7902667aadcbaffb0f

		[Required, MaxLength(30)]
		public required string Status { get; set; }

		[Required]
		public DateTime CreatedOn { get; set; }

		[Required]
		public bool IsDeleted { get; set; }

		[Required]
		public DateTime UpdatedOn { get; set; }
	}
}