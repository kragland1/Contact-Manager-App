using Microsoft.EntityFrameworkCore;

namespace Contact_Manager_App.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friend" },
                new Category { CategoryId = 2, Name = "Family" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Other" }
                );
            modelBuilder.Entity<Contact>().HasData(
                new Contact { ContactId = 1, Firstname = "David", Lastname = "Henry", Phone = "270-788-8899",
                    Email = "Dav.Hen@aol.com",
                    CategoryId = 1,
                DateAdded = DateTime.Now},
                new Contact
                {
                    ContactId = 2,
                    Firstname = "Jimmy",
                    Lastname = "Lee",
                    Phone = "707-556-8569",
                    Email = "JimJimLeeson@yahoo.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    Firstname = "George",
                    Lastname = "Santos",
                    Phone = "270-988-5667",
                    Email = "Geo.Santo@gmail.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                }
                );
        }


    }
}
