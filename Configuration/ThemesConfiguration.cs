
using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Configuration;

public class ThemesConfiguration:IEntityTypeConfiguration<Themes>
{
    public void Configure(EntityTypeBuilder<Themes> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasDefaultValue("Name");
    }
}
