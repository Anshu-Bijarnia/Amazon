using Amazon.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Amazon.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Healthy Living & Wellness", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Meditation", DisplayOrder = 2 },
                new Category { Id = 3, Name = "UPSC", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Manga", DisplayOrder = 4 }
                );
            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Aurelius", StreetAddress = "Regal building 69, Connaught Place", City = "New Delhi", PostalCode = "110001", State = "Delhi", PhoneNumber = "26387483" },
                new Company { Id = 2, Name = "Booknerds", StreetAddress = "123", City = "Vid City", PostalCode = "56434", State = "IL", PhoneNumber = "4387568" },
                new Company { Id = 3, Name = "Creative Circle", StreetAddress = "123", City = "Lala land", PostalCode = "34543", State = "NY", PhoneNumber = "23487623" }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Atomic Habits",
                    Author = "James Clear",
                    Description = "THE PHENOMENAL INTERNATIONAL BESTSELLER: OVER 1O MILLION COPIES SOLD WORLDWIDE\r\n\r\nTransform your life with tiny changes in behaviour, starting now.\r\n\r\nPeople think that when you want to change your life, you need to think big. But world-renowned habits expert James Clear has discovered another way. He knows that real change comes from the compound effect of hundreds of small decisions: doing two push-ups a day, waking up five minutes early, or holding a single short phone cal",
                    ISBN = "SWD9999001",
                    ListPrice = 799,
                    Price = 508,
                    Price50 = 475,
                    Price100 = 450,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Lifes Amazing Secrets",
                    Author = "Gaur Gopal Das",
                    Description = "Stop going through life,\r\nStart growing through life!\r\n\r\nWhile navigating their way through Mumbai's horrendous traffic, Gaur Gopal Das and his wealthy young friend Harry get talking, delving into concepts ranging from the human condition to finding one's purpose in life and the key to lasting happiness.",
                    ISBN = "CAW777777701",
                    ListPrice = 250,
                    Price = 237,
                    Price50 = 220,
                    Price100 = 210,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Ikigai",
                    Author = "Francesc Miralles",
                    Description = "THE INTERNATIONAL BESTSELLER\r\n\r\nWe all have an ikigai.\r\n\r\nIt's the Japanese word for ‘a reason to live’ or ‘a reason to jump out of bed in the morning’.\r\n\r\nIt’s the place where your needs, desires, ambitions, and satisfaction meet. A place of balance. Small wonder that finding your ikigai is closely linked to living longer.",
                    ISBN = "RITO5555501",
                    ListPrice = 359,
                    Price = 319,
                    Price50 = 305,
                    Price100 = 295,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    Title = "Focus on What Matters",
                    Author = "Darius Foroux",
                    Description = "Why is it so hard to live well amidst the chaos and noise? While you might think this is a problem of the modern world, it's a timeless issue.\r\n2000 years ago, the ancient Stoics talked about the exact same challenges we're facing today, like:\r\n• How can we find inner peace?\r\n• What does it take to be happy?\r\n• Can we become more resilient?\r\nThe answers can be found in the philosophy of Stoicism. ",
                    ISBN = "WS3333333301",
                    ListPrice = 299,
                    Price = 168,
                    Price50 = 155,
                    Price100 = 145,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Indian Polity",
                    Author = "M Laxmikanth",
                    Description = "McGraw Hill presents the seventh edition of the consistent best seller and the most celebrated title on the subject – Indian Polity by M Laxmikanth. The book is a must-read for the aspirants appearing for the UPSC – Civil Services Examination as well as the other State Services examinations.",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 1045,
                    Price = 700,
                    Price50 = 675,
                    Price100 = 650,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 6,
                    Title = "Jujutsu Kaisen Vol 1",
                    Author = "Gege Akutami",
                    Description = "Yuji Itadori is resolved to save the world from cursed spirits, but he soon learns that the best way to do it is to slowly lose his humanity and become one himself!In a world where cursed spirits feed on unsuspecting humans, fragments of the legendary and feared demon Ryomen Sukuna were lost and scattered about. Should any demon consume Sukuna’s body parts, the power they gain could destroy the world as we know it. ",
                    ISBN = "FOT000000001",
                    ListPrice = 830,
                    Price = 467,
                    Price50 = 450,
                    Price100 = 435,
                    CategoryId = 4
                },
                new Product
                {
                    Id = 7,
                    Title = "One-Punch Man Vol 1",
                    Author = "ONE",
                    Description = "Life gets pretty boring when you can beat the snot out of any villain with just one punch.",
                    ISBN = "FOT000000001",
                    ListPrice = 962,
                    Price = 489,
                    Price50 = 475,
                    Price100 = 450,
                    CategoryId = 4
                }
                );
        }
    }
}