using CSPT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.Interfaces
{
    public interface IPostsService
    {
        Task<IEnumerable<Post>> GetPostsAsync();
    }
}
