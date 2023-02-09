using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityFrameWork_Hw2.Configuration;

public class DepartmentsConfigure : IEntityTypeConfiguration<Departments>
{
    public void Configure(EntityTypeBuilder<Departments> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}

