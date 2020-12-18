using CSPT.Data.Models;
using CSPT.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace CSPT.Mongo.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly CsptContext context;

        public PostRepository(CsptContext csptContext)
        {
            this.context = csptContext;
        }

        public async Task CreateAsync(Post post)
        {
            await context.Posts.InsertOneAsync(post);
        }

        public async Task<IEnumerable<Post>> GetAllAsync()
        {
            var cursor = await context.Posts.FindAsync(_ => true);
            return cursor.ToEnumerable();
        }
    }
}
