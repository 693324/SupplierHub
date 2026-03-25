using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class User
	{
		[Key]
		public long UserID { get; set; }

		public long? OrgID { get; set; }

		[Required, MaxLength(150)]
		public string UserName { get; set; } = null!;

		[Required, MaxLength(150)]
		public string Email { get; set; } = null!;

		[MaxLength(30)]
		public string? Phone { get; set; }

		[MaxLength(255)]
		public string? PasswordHash { get; set; }

		[Required, MaxLength(30)]
		public string Status { get; set; } = null!;

		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }
		public bool IsDeleted { get; set; }

		// ✅ Navigation (ONLY collection, no FK attributes)
		public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
	}
}