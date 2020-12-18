using CSPT.Data.Models;
using CSPT.Data.Repositories;
using CSPT.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.Services
{
    public class PostsService : IPostsService
    {
        private readonly IPostRepository postRepository;

        public PostsService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public async Task<IEnumerable<Post>> GetPostsAsync()
        {
            return await postRepository.GetAllAsync();
        }
    }
}
