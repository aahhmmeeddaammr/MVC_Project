using App.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Data.Confugrations
{
	internal class DepartmentConfugration : IEntityTypeConfiguration<Department>
	{
		public void Configure(EntityTypeBuilder<Department> builder)
		{
			builder.Property(e=>e.ID).UseIdentityColumn(1000,10);
			builder.Property(e => e.Name).IsRequired();
			builder.Property(e => e.DateOfCreation).HasDefaultValueSql("GETDATE()");

		}
	}
}
