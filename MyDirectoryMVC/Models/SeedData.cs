using Microsoft.EntityFrameworkCore;
using MyDirectoryMVC.Data;

namespace MyDirectoryMVC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyDirectoryMVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MyDirectoryMVCContext>>()))
            {
                
                if (context.Contact.Any())
                {
                    return;   
                }

                context.Contact.AddRange(
                    new Contact
                    {
                        Name = "Juan",
                        LastName = "Ochoa",
                        Telephone = "3311144525",
                        Email = "juan.ochoa@gmail.com"
                    },

                    new Contact
                    {
                        Name = "Laura",
                        LastName = "Herrera",
                        Telephone = "3542144424",
                        Email = "laura.herrera@gmail.com"
                    },

                    new Contact
                    {
                        Name = "Omar",
                        LastName = "Aguilar",
                        Telephone = "5552451025",
                        Email = "omar.aguilar@gmail.com"
                    },

                    new Contact
                    {
                        Name = "Alejandra",
                        LastName = "Miranda",
                        Telephone = "4521452008",
                        Email = "ale.miranda@gmail.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
