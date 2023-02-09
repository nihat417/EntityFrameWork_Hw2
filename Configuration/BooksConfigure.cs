using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Hw2.Configuration;

public class BooksConfigure:IEntityTypeConfiguration<Books>
{
    public void Configure(EntityTypeBuilder<Books> builder)
    {
        builder.HasOne<Themes>()
            .WithMany()
            .HasForeignKey(x => x.Id_Themes);

        builder.HasOne<Press>()
            .WithMany()
            .HasForeignKey(x=>x.Id_Press);

        builder.HasOne<Authors>()
            .WithMany()
            .HasForeignKey(x => x.Id_Author);

        builder.HasOne<Category>()
            .WithMany()
            .HasForeignKey(x => x.Id_Category);
    }
}
