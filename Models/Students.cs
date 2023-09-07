using System.ComponentModel.DataAnnotations;

namespace WebAPIproject4.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Marks { get; set; }
    }
}
