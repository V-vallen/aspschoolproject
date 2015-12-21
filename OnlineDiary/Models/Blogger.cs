using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiary.Models
{
    public class Blogger
    {


        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(60)]
        [Display(Name ="Blogger Name")]
        public string Name { get; set; }
        
        
    }
    public class BloggerDbContext : DbContext
    {
        public DbSet<Blogger> Bloggers { get; set; }
    }
}
