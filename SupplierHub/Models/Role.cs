using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SupplierHub.Models
{
	public class Role
	{
		[Key]
		public long RoleID { get; set; }

		[Required, MaxLength(100)]
		public string RoleName { get; set; } = null!;

		[Required, MaxLength(30)]
		public string Status { get; set; } = null!;

		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }
		public bool IsDeleted { get; set; }

		// ✅ Navigation
		public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
	}
}