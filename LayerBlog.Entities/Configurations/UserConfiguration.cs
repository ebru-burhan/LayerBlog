using LayerBlog.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Entities.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne<Picture>(x => x.Picture)
                    .WithOne()
                    .HasForeignKey<User>(x => x.PictureId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict); // <-- Here it is
        }
    }
}
