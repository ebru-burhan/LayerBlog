using LayerBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LayerBlog.Models.DataTransferObjects
{
    public class PostDTO
    {

        //public PostDTO(Post post)
        //{
        //    //automapper yapmadan nasıl yaparız ?? ahanda böyle hoj diil
        //    PostID = post.PostID;
        //    Title = post.Title;
        //    Description = post.Description;
        //    PictureId = post.PictureId;
        //    Picture = post.Picture == null ? null : new PictureDTO(post.Picture);
        //}


        public int PostID { get; set; }
        public int CategoryId { get; set; }
        public int? PictureId { get; set; }

        [Required]
        [MaxLength(500), MinLength(2)]
        public string Title { get; set; }

        [Required]
        [MinLength(2)]
        public string Description { get; set; }



        //----relations
        public CategoryDTO Category { get; set; }
        public List<FavoritePostDTO> FavoritePosts { get; set; }
        public PictureDTO Picture { get; set; }
        public List<CommentDTO> Comments { get; set; }


    }
}
