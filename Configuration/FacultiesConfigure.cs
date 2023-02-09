using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameWork_Hw2.Models;

namespace EntityFrameWork_Hw2.Configuration;

public class FacultiesConfigure : IEntityTypeConfiguration<Faculties>
{
    public void Configure(EntityTypeBuilder<Faculties> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}

