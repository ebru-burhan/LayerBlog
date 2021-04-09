using LayerBlog.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Entities.Configurations
{
    public class FavoritePostConfiguration : IEntityTypeConfiguration<FavoritePost>
    {
        public void Configure(EntityTypeBuilder<FavoritePost> builder)
        {
            builder.HasKey(x => new { x.UserId, x.PostId });

            builder
                .HasOne<User>(x => x.User)
                .WithMany(favPost => favPost.FavoritePosts)
                .HasForeignKey(x => x.UserId);

            builder
                .HasOne<Post>(x => x.Post)
                .WithMany(favPost => favPost.FavoritePosts)
                .HasForeignKey(x => x.PostId);
        }
    }
}
