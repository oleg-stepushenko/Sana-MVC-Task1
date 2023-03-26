using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class User
    {
        [Required]
        public string Name { set; get; }
    }
}

