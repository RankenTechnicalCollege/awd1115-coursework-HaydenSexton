using Microsoft.EntityFrameworkCore;

namespace FAQProject.Models
{
    public class FaqsContext : DbContext
    {
        public FaqsContext(DbContextOptions<FaqsContext> options) : base(options) { }
        public DbSet<FAQ> FAQs { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Topic> Topics { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "gen", Name = "General" },
                new Category { CategoryId = "hist", Name = "History" }
                );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { TopicId = "asp", Name = "ASP.NET Core" },
                new Topic {  TopicId = "blz", Name = "Blazor" },
                new Topic { TopicId = "ef", Name = "Entity Framework" }
                );

            modelBuilder.Entity<FAQ>().HasData(
                new FAQ
                {
                    FAQId = 1,
                    Question = "What is ASP.NET Core?",
                    Answer = "ASP.NET Core is a free and open-source web framework developed by Microsoft for building modern, cloud-based, and internet-connected applications.",
                    CategoryId = "gen",
                    TopicId = "asp"
                },
                new FAQ
                {
                    FAQId = 2,
                    Question = "What is Blazor?",
                    Answer = "Blazor is a framework for building interactive client-side web UIs with .NET. It allows developers to use C# instead of JavaScript for web development.",
                    CategoryId = "gen",
                    TopicId = "blz"
                },
                new FAQ
                {
                    FAQId = 3,
                    Question = "What is Entity Framework?",
                    Answer = "Entity Framework (EF) is an object-relational mapper (ORM) for .NET that enables developers to work with databases using .NET objects, reducing the need for direct SQL.",
                    CategoryId = "gen",
                    TopicId = "ef"
                },
                new FAQ
                {
                    FAQId = 4,
                    Question = "When was ASP.NET Core released?",
                    Answer = "ASP.NET Core was first released in 2016 as the successor to ASP.NET, designed for cross-platform development.",
                    CategoryId = "hist",
                    TopicId = "asp"
                },
                new FAQ
                {
                    FAQId = 5,
                    Question = "When was Blazor introduced?",
                    Answer = "Blazor was introduced by Microsoft in 2018 as part of the ASP.NET family of technologies.",
                    CategoryId = "hist",
                    TopicId = "blz"
                },
                new FAQ
                {
                    FAQId = 6,
                    Question = "When was Entity Framework first released?",
                    Answer = "Entity Framework was first released in 2008 as part of .NET Framework 3.5 Service Pack 1.",
                    CategoryId = "hist",
                    TopicId = "ef"
                }
            );

        }
    }
}
