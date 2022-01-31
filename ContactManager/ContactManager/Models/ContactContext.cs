using Microsoft.EntityFrameworkCore;

namespace ContactManager.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options) { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friend" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { 
                    ContactId = 1, 
                    Firstname = "Frodo",
                    Lastname =  "Baggins",
                    Phone = "416-123-4567",
                    Email = "forodo@domain.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now,
                },

                new Contact
                {
                    ContactId = 2,
                    Firstname = "Samwise",
                    Lastname = "Gamgee",
                    Phone = "647-123-4567",
                    Email = "samwise@domain.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now,
                },

                new Contact
                {
                    ContactId = 3,
                    Firstname = "Pippen",
                    Lastname = "Took",
                    Phone = "905-123-4567",
                    Email = "pippen@domain.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now,
                }
                );
        }
    }
}
