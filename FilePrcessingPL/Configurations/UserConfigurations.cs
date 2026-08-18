using FileProcessingDM.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessingPL.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(80).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(256).IsRequired();
            //set new table name
        }
    }
}
