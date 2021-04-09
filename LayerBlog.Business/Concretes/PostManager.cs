using AutoMapper;
using LayerBlog.Business.Abstracts;
using LayerBlog.DataAccess.Abstracts;
using LayerBlog.Entities.Concretes;
using LayerBlog.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LayerBlog.Business.Concretes
{
    public class PostManager : IPostService
    {
        private readonly IPostRepository _postRepository;
        private readonly IMapper _mapper;
        public PostManager(IPostRepository postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }
        public List<PostDTO> GetPosts()
        {
            var posts = _postRepository.GetAll();
            return _mapper.Map<List<PostDTO>>(posts);
            //automappersiz nasıl yapıyoz
            /*
            List<PostDTO> listPost = new List<PostDTO>();

            foreach (Post post in posts)
            {
                PostDTO dto = new PostDTO(post);
                listPost.Add(dto);
            }

            return listPost;
            */
        }

        public void AddPost(Post postDto)
        {
            _postRepository.Add(_mapper.Map<Post>(postDto));
        }

        public PostDTO GetPostDtoById(int id)
        {
            Post post =_postRepository.GetPostById(id);
            return _mapper.Map<PostDTO>(post);
        }
    }
}
