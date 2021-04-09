using LayerBlog.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Entities.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasOne<Picture>(x => x.Picture)
                    .WithOne()
                    .HasForeignKey<Post>(x => x.PictureId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict); // <-- Here it is
            //willcascadeondelete .net de.. core da bu şeklde
        }
    }
}
