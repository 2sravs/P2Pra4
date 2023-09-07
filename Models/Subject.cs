using System.ComponentModel.DataAnnotations;

namespace WebAPIproject4.Models
{
    public class Subject
    {
        [Key]
        public int SubId { get; set; }
        public string SubName { get; set; }

    }
}
