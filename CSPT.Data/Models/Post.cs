using System;
using System.Collections.Generic;
using System.Text;

namespace CSPT.Data.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
