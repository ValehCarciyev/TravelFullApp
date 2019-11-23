using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelApp.Models;

namespace TravelApp.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions option) : base(option) { }
       
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutLanguage> AboutLanguages { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceLanguage> ServiceLanguages { get; set; }
        public DbSet<ServicePhoto> ServicePhotos { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SettingLanguage> SettingLanguages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<TestimonialLanguage> TestimonialLanguages { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
