// PetAdoptionPortal.Infrastructure/Data/AppDbContext.cs
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetAdoptionPortal.Infrastructure.Entities;

namespace PetAdoptionPortal.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //seed 10 adoptable pets

            builder.Entity<Pet>().HasData(
               new Pet { Id = 1, Name = "Chuchu", Species = "Dog", Age = 2, Gender = "Female", Personality = "Loves cuddles and belly rubs.", Status = "Available", ImageUrl = "/images/chuchu.jpg" },
                new Pet { Id = 2, Name = "Milo", Species = "Cat", Age = 1, Gender = "Male", Personality = "Always curious about everything.", Status = "Available", ImageUrl = "/images/milo.jpg" },
                new Pet { Id = 3, Name = "Bella", Species = "Dog", Age = 3, Gender = "Female", Personality = "Playful and full of energy.", Status = "Available", ImageUrl = "/images/bella.jpg" },
                new Pet { Id = 4, Name = "Luna", Species = "Cat", Age = 2, Gender = "Female", Personality = "Loyal and protective of loved ones.", Status = "Available", ImageUrl = "/images/luna.jpg" },
                new Pet { Id = 5, Name = "Max", Species = "Dog", Age = 4, Gender = "Female", Personality = "Enjoys napping under the sun", Status = "Available", ImageUrl = "/images/max.jpg" },
                new Pet { Id = 6, Name = "Oliver", Species = "Cat", Age = 1, Gender = "Male", Personality = "Shy at first but very sweet.", Status = "Available", ImageUrl = "/images/oliver.jpg" },
                new Pet { Id = 7, Name = "Daisy", Species = "Dog", Age = 3, Gender = "Female", Personality = "Loves exploring new places", Status = "Available", ImageUrl = "/images/daisy.jpg" },
                new Pet { Id = 8, Name = "Simba", Species = "Cat", Age = 2, Gender = "Male", Personality = "Smart and easy to train.", Status = "Available", ImageUrl = "/images/simba.jpg" },
                new Pet { Id = 9, Name = "Coco", Species = "Dog", Age = 5   , Gender = "Female", Personality = "Gentle and calm around kids.", Status = "Available", ImageUrl = "/images/coco.jpg" },
                new Pet { Id = 10, Name = "Leo", Species = "Cat", Age = 1, Gender = "Male", Personality = "Can’t resist a tasty treat.", Status = "Available", ImageUrl = "/images/leo.jpg" }
        );
    }

}

}