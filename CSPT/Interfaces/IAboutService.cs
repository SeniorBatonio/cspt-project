using CSPT.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.Interfaces
{
    public interface IAboutService
    {
        Task<IEnumerable<About>> GetAboutInfoAsync();
    }
}
