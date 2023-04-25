using productshop.Models;

namespace productshop.Data
{
    public class DbInitilizer
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                if(!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category(){TypeName = "áo"},
                        new Category(){TypeName = "áo polo"},
                        new Category(){TypeName = "áo sơmi"},
                        new Category(){TypeName = "quần"},
                        new Category(){TypeName = "quần kaki"},
                        new Category(){TypeName = "quần jeans"},
                    });
                }
                context.SaveChanges();
            }
        }
    }
}
