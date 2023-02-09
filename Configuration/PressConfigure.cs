using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Configuration;

public class PressConfigure:IEntityTypeConfiguration<Press>
{
    public void Configure(EntityTypeBuilder<Press> builder)
    {
        builder.Property(x => x.Name).IsRequired().HasDefaultValue("Name");
    }
}
