using System.ComponentModel.DataAnnotations;

namespace VideoDemo.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
