using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Configuration;

public class CategoryConfigure:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> Builder)
    {
        Builder.Property(x => x.Name).IsRequired().HasDefaultValue("name");
    }
}
