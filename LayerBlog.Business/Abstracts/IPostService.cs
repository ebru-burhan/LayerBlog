using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace LayerBlog.Business.Abstracts
{
    public interface IPostService : IService
    {
        List<PostDTO> GetPosts();
        PostDTO GetPostDtoById(int id);
    }
}
