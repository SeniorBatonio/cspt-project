using CSPT.Data.Models;
using CSPT.Data.Repositories;
using CSPT.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPT.Services
{
    public class AboutService : IAboutService
    {
        private readonly IAboutRepository aboutRepository;

        public AboutService(IAboutRepository aboutRepository)
        {
            this.aboutRepository = aboutRepository;
        }

        public async Task<IEnumerable<About>> GetAboutInfoAsync()
        {
            return await aboutRepository.GetAllAsync();
        }
    }
}
