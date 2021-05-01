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
            var posts = _postRepository.GetAllPosts();
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


        public PostDTO GetPostById(int id)
        {
            Post post =_postRepository.GetPostById(id);
            return _mapper.Map<PostDTO>(post);
        }


        public List<PostDTO> GetPostsByCategory(CategoryDTO categoryDto)
        {
            return _mapper.Map<List<PostDTO>>(_postRepository.GetPostsByCategoryId(categoryDto.CategoryID));
        }

        public void AddPost(PostDTO postDto)
        {
            //newliyo burda ekliyo
            _postRepository.Add(_mapper.Map<Post>(postDto));
        }

        public void UpdatePost(PostDTO postDto)
        {
            var post = _postRepository.GetPostById(postDto.PostID);
            _postRepository.Update(_mapper.Map(postDto,post));
            //bu şeklde Post olarak newliyo ve update olacak context dekiyle çakışıyo dyo 2 tne oldu aynı id li bizde track etme dyoduk çözyo görnyoduk ama track etmesi gerekn diğer şeyler  edlmemş oluyodu yanlışa davetye risk teşkil eder benm için
            //_postRepository.Update(_mapper.Map<Post>(postDto));
        }

        public void DeletePost(int id)
        {
            _postRepository.Delete(_postRepository.GetPostById(id));
        }

    }
}
