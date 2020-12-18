using CSPT.Data.Models;
using CSPT.Mongo;
using CSPT.Mongo.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSPT.InitMongo
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Press 1 to init mongodb:");
            var txt = Console.ReadLine();
            if (int.TryParse(txt, out var status))
            {
                if (status != 1)
                {
                    return;
                }

                var context = new CsptContext("mongodb://localhost/CSPTDB");
                var postRepository = new PostRepository(context);
                var aboutRepository = new AboutRepository(context);

                var about = new List<About>
                {
                    new About
                    {
                        Id = Guid.NewGuid(),
                        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ullam doloremque porro labore totam fugiat voluptate! Suscipit necessitatibus earum debitis reprehenderit quibusdam ad. Voluptatem distinctio ipsa dolorem esse recusandae placeat, iusto odio! Molestias ratione numquam, cum, tempora sint ducimus unde porro dicta veniam perferendis illo at qui velit soluta voluptatum quo, et voluptatem natus laboriosam sunt harum. Doloremque nobis tempora odio, deserunt assumenda nesciunt temporibus iure similique facere, illum ipsum dolore nemo rem nam omnis necessitatibus quaerat quod eveniet quo quasi ab tenetur. Delectus nihil totam voluptatibus dolorum cum impedit pariatur, quaerat veritatis tenetur fugiat iste repudiandae necessitatibus vitae quas harum."
                    },
                    new About
                    {
                        Id = Guid.NewGuid(),
                        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ullam doloremque porro labore totam fugiat voluptate! Suscipit necessitatibus earum debitis reprehenderit quibusdam ad. Voluptatem distinctio ipsa dolorem esse recusandae placeat, iusto odio! Molestias ratione numquam, cum, tempora sint ducimus unde porro dicta veniam perferendis illo at qui velit soluta voluptatum quo, et voluptatem natus laboriosam sunt harum. Doloremque nobis tempora odio, deserunt assumenda nesciunt temporibus iure similique facere, illum ipsum dolore nemo rem nam omnis necessitatibus quaerat quod eveniet quo quasi ab tenetur. Delectus nihil totam voluptatibus dolorum cum impedit pariatur, quaerat veritatis tenetur fugiat iste repudiandae necessitatibus vitae quas harum."
                    }
                };

                var posts = new List<Post>
                {
                    new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = "Baking with Oranges",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fugit et, iure recusandae quas sed nemo reiciendis deserunt ea labore doloribus illo saepe, id eum nam, ipsam rerum reprehenderit praesentium neque odio! Sapiente quisquam aspernatur, sed vel hic vero commodi deleniti culpa praesentium voluptatibus esse, distinctio voluptas consequuntur obcaecati reiciendis ratione.",
                        ImageUrl = "https://data2.1freewallpapers.com/download/orange-citrus-slice.jpg"
                    },
                    new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = "The street food in Bangkok",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fugit et, iure recusandae quas sed nemo reiciendis deserunt ea labore doloribus illo saepe, id eum nam, ipsam rerum reprehenderit praesentium neque odio! Sapiente quisquam aspernatur, sed vel hic vero commodi deleniti culpa praesentium voluptatibus esse, distinctio voluptas consequuntur obcaecati reiciendis ratione.",
                        ImageUrl = "https://topfacts.com.ua/sites/default/files/field/image/yaponiya-otlichnaya-ideya-dlya-puteshestviya-2.jpg"
                    },
                    new Post
                    {
                        Id = Guid.NewGuid(),
                        Title = "Make Omlettes super fluffy",
                        Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Fugit et, iure recusandae quas sed nemo reiciendis deserunt ea labore doloribus illo saepe, id eum nam, ipsam rerum reprehenderit praesentium neque odio! Sapiente quisquam aspernatur, sed vel hic vero commodi deleniti culpa praesentium voluptatibus esse, distinctio voluptas consequuntur obcaecati reiciendis ratione.",
                        ImageUrl = "https://craftlog.com/m/i/3057545=s1280=h960"
                    }
                };
                foreach(var a in about)
                {
                    await aboutRepository.CreateAsync(a);
                }

                foreach (var p in posts)
                {
                    await postRepository.CreateAsync(p);
                }
            }
        }
    }
}
