using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class TaskModel
    {
        [Required]
        public string Matrix { get; set; }
    }
}