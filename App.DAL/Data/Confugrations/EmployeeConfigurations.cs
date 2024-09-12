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
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(E=>E.Name).HasColumnType("varchar(50)");
            builder.Property(E => E.Salary).HasColumnType("decimal(18,2)");
            builder.Property(E => E.CreationDate).HasDefaultValueSql("GETDATE()");
            builder.Property(E => E.Address).IsRequired();
            
        }
    }
}
