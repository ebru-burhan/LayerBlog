using AutoMapper;
using LayerBlog.Entities.Concretes;
using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //reverse map dtodan entty yapmayı da sağlıyo
            CreateMap<Post, PostDTO>().ReverseMap();
            //CreateMap<PostDTO, Post>();

            CreateMap<User, UserDTO>().ReverseMap();
            //CreateMap<UserDTO, User>();

            CreateMap<Category, CategoryDTO>().ReverseMap();
            //CreateMap<CategoryDTO, Category>();

            CreateMap<Comment, CommentDTO>().ReverseMap();
            //CreateMap<CommentDTO, Comment>();

            CreateMap<Picture, PictureDTO>().ReverseMap();
            //CreateMap<PictureDTO, Picture>();

            CreateMap<FavoritePost, FavoritePostDTO>().ReverseMap();
            //CreateMap<FavoritePostDTO, FavoritePost>();
        }
    }
}
