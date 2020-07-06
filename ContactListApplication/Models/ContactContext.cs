using Microsoft.EntityFrameworkCore;

namespace ContactListApplication.Models
{
    public class ContactContext : DbContext
    {
        //Set up for mmy contact list database.
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        public DbSet<ContactInfo> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=tcp:cis174enmccloud.database.windows.net,1433;Initial Catalog=CIS174enmccloud;Persist Security Info=False;User ID=enmccloud;Password=Skittles5309;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Table build data.
            modelBuilder.Entity<ContactInfo>().HasData(
                new ContactInfo
                {
                    ContactId = 1,
                    Name = "Nikki McCloud",
                    PhoneNumber = "712-210-5283",
                    Address = "309 Arthur Neu Dr.",
                    City = "Carroll",
                    StateAbbr = "IA",
                    ZipCode = 51401,
                    Note = "Myself.",
                },
                new ContactInfo
                {
                    ContactId = 2,
                    Name = "Jon Campbell",
                    PhoneNumber = "712-830-5158",
                    Address = "309 Arthur Neu Dr.",
                    City = "Carroll",
                    StateAbbr = "IA",
                    ZipCode = 51401,
                    Note = "Fiance",
                },
                new ContactInfo
                {
                    ContactId = 3,
                    Name = "Jason Sudekis",
                    PhoneNumber = "555-555-5555",
                    Address = "369 Troy Dr.",
                    City = "Los Angeles",
                    StateAbbr = "CA",
                    ZipCode = 90001,
                    Note = "Famous Celebrity",
                }
            );

        }
    }
}
