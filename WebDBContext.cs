using Microsoft.EntityFrameworkCore;

namespace AZ_datapage.Models
{
    public class WebDBContext:DbContext
    {

        public WebDBContext(DbContextOptions<WebDBContext> options) : base(options)
        {

        }
        public DbSet<DataModel> Datamodeler { get; set; }
    }



}

