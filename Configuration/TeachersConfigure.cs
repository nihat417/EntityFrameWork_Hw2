using EntityFrameWork_Hw2.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EntityFrameWork_Hw2.Configuration;

public class TeachersConfigure : IEntityTypeConfiguration<Teachers>
{
    public void Configure(EntityTypeBuilder<Teachers> builder)
    {        
        builder.HasOne<Departments>()
            .WithMany()
            .HasForeignKey(x => x.Id_Dep);
    }

}
