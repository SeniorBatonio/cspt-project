using CSPT.Data.Models;
using CSPT.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CSPT.Mongo.Repositories
{
    public class AboutRepository : IAboutRepository
    {
        private readonly CsptContext context;

        public AboutRepository(CsptContext csptContext)
        {
            this.context = csptContext;
        }

        public async Task CreateAsync(About about)
        {
            await context.About.InsertOneAsync(about);
        }

        public async Task<IEnumerable<About>> GetAllAsync()
        {
            var cursor = await context.About.FindAsync(_ => true);
            return cursor.ToEnumerable();
        }
    }
}
