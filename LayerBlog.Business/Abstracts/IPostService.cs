﻿using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface IPostService : IService
    {
        List<PostDTO> GetPosts();
        PostDTO GetPostDtoById(int id);
        List<PostDTO> GetPostDtoByCategory(CategoryDTO categoryDto);

        void AddPost(PostDTO postDto);
        void UpdatePost(PostDTO postDto);
        void DeletePost(int id);

    }
}
