using CSPT.Data.Models;
using System.Collections.Generic;

namespace CSPT.Models
{
    public class LandingViewModel
    {
        public IEnumerable<string> AboutMe { get; set; }
        public IEnumerable<Post> Posts { get; set; }
    }
}
