using CSPT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.Data.Repositories
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetAllAsync();
        Task CreateAsync(Post post);
    }
}
