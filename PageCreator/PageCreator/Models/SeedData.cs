using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PageCreator.Data;
using System;
using System.Linq;

namespace PageCreator.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PageCreatorContext(serviceProvider.GetRequiredService<
                DbContextOptions<PageCreatorContext>>()))
            {
                if (context.Users.Any() && context.Pages.Any())
                {
                    return;
                }
                else if(!context.Users.Any())
                {
                    context.Users.AddRange(
                    new Users("sniper228@gmail.com", "password1"),
                    new Users("user123@gmail.com", "password2"),
                    new Users("nagibator3000@gmail.com", "password3")
                    );
                    context.SaveChanges();
                }
                if (!context.Pages.Any())
                {
                    context.Pages.AddRange(
                        new Pages("Title1", "public", 2, "JSON Content1"),
                        new Pages("Title2", "private", 3, "JSON Content2"),
                        new Pages("Title3", "public", 1, "JSON Content3")
                        );
                    context.SaveChanges();
                }
                
            }
        }
    }
}