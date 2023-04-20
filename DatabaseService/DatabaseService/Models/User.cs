using System.ComponentModel.DataAnnotations;

namespace DatabaseService.Models

{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Hobby { get; set; }

    }
}
