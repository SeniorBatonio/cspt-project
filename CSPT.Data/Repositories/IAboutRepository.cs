using CSPT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.Data.Repositories
{
    public interface IAboutRepository
    {
        Task<IEnumerable<About>> GetAllAsync();
        Task CreateAsync(About about);
    }
}
