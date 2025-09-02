using System.ComponentModel.DataAnnotations;

namespace Lab10.Models.Entities
{
    public class Post
    {
        [Key]
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
    }
}
