using Lucra_Assessment_Image_Gallery.Models;
using Microsoft.EntityFrameworkCore;

namespace Lucra_Assessment_Image_Gallery.Data
{
	public class ImageUploadDbContext : DbContext
	{
        public ImageUploadDbContext(DbContextOptions<ImageUploadDbContext> options) : base(options)
        {
        }

		public DbSet<ImageModel> Images { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImageModel>();
        }
    }
}
