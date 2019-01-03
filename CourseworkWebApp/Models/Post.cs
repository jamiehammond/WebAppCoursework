using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

// Model class for a post - Must contain a title and some content text. May be commented on by other users.
namespace CourseworkWebApp.Models
{
    public class Post
    {
        // ID no. of the post
        public int PostID { get; set; }

        // User ID of the original poster
        public int PosterID { get; set; }

        // Username of the original poster
        public string PosterName { get; set; }

        // Date and time of the creation of the post
        public DateTime PostedDateTime { get; set; }

        // Title of the post, max length of 50 characters
        [StringLength(50)]
        [Required]
        public string Title { get; set; }

        // Main body of the post, max length of 200 characters
        [StringLength(200)]
        [Required]
        public string Content { get; set; }

        // List of comments on the post
        public List<Comment> Comments { get; set; }
    }
}
