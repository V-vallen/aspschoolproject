using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineDiary.Models
{
    public enum Tag
    {
        BadDay,
        Cuold_Be_Worse,
        Nothing_Special,
        Pretty_Good,
        Best_Day_of_My_Life
    }
    public class Event
    {

        public int EventId { get; set; }
        public int UserId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required]
        public String Title { get; set; }
        public String Content { get; set; }
        [Display(Name = "How was it?")]
        public Tag Tag { get; set; }
        /* [Display(Name = "Image")]
         public int ImageId { get; set; }
         [Display(Name = "Tag Friends")]
         public int FriendId { get; set; }*/

    }
    

    public class EventDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
