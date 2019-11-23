namespace Assignment_NET.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Assignment_NET.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Assignment_NET.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Assignment_NET.Models.MyDbContext context)
        {
            context.Categories.AddOrUpdate(x => x.Id,
                new Category() { Id = 1, Name = "Trousers" },
                new Category() { Id = 2, Name = "shirt" },
                new Category() { Id = 3, Name = "Hat" },
                new Category() { Id = 4, Name = "Diapers" }
            );

            context.Products.AddOrUpdate(x => x.Id,
                new Product()
                {
                    Id = 1,
                    Name = "Sport shorts",
                    Price = 150,
                    Image = "https://babi.vn/images/companies/1/Up%20hinh%20san%20pham/24272/quan-dai-the-thao-cho-be-ke-soc-sanh-dieu-3-9-tuoi%20(5).jpg?1534159274991",
                    Description = "Sport",
                    Gender = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Shirt",
                    Price = 100,
                    Image = "https://babi.vn/images/companies/1/Up%20hinh%20san%20pham/26985/bo-be-trai-the-thao-nang-dong%20(2).jpg?1465462153557",
                    Description = "Shirt",
                    Gender = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Hat",
                    Price = 200,
                    Image = "https://my-test-11.slatic.net/p/9acc3b0d3446a59535f13b6cb856984e.jpg_340x340q80.jpg_.webp",
                    Description = "Hat",
                    Gender = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Diapers",
                    Price = 300,
                    Image = "https://my-test-11.slatic.net/p/d5ca9c86020623bddb4eddc240b394d1.jpg_340x340q80.jpg_.webp",
                    Description = "Diapers",
                    Gender = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Sport shorts",
                    Price = 150,
                    Image = "https://babi.vn/images/companies/1/Up%20hinh%20san%20pham/24272/quan-dai-the-thao-cho-be-ke-soc-sanh-dieu-3-9-tuoi%20(5).jpg?1534159274991",
                    Description = "Sport",
                    Gender = 0
                },
                new Product()
                {
                    Id = 6,
                    Name = "Shirt",
                    Price = 100,
                    Image = "https://babi.vn/images/companies/1/Up%20hinh%20san%20pham/26985/bo-be-trai-the-thao-nang-dong%20(2).jpg?1465462153557",
                    Description = "Shirt",
                    Gender = 0
                },
                new Product()
                {
                    Id = 7,
                    Name = "Hat",
                    Price = 200,
                    Image = "https://my-test-11.slatic.net/p/9acc3b0d3446a59535f13b6cb856984e.jpg_340x340q80.jpg_.webp",
                    Description = "Hat",
                    Gender = 0
                },
                new Product()
                {
                    Id = 8,
                    Name = "Diapers",
                    Price = 300,
                    Image = "https://my-test-11.slatic.net/p/d5ca9c86020623bddb4eddc240b394d1.jpg_340x340q80.jpg_.webp",
                    Description = "Diapers",
                    Gender = 0
                }
            );
        }
    }
}
