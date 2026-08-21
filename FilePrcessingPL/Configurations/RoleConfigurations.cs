using FileProcessingDM.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.Configurations
{
    public class RoleConfigurations : IEntityTypeConfiguration<Roles>
    {
        public void Configure(EntityTypeBuilder<Roles> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedNever(); //primary key but not auto increment
            builder.Property(x => x.RoleName).HasMaxLength(50).IsRequired();
            //noramlized name uppercase set auto
            builder.Property(x => x.NormalizedName).HasComputedColumnSql("UPPER([RoleName])"); //computed column set auto
        }
    }
}
