// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models;

// [NotMapped] taghelper will define a class/property to not be stored in your db
public class Post
{
    [Key]
    public int PostId { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    [MaxLength(45, ErrorMessage = "must be shorter than 45 characters")]
    [Display(Name = "Favorite Topic")]
    public string Topic { get; set; }

    [Required(ErrorMessage = "is required")]
    [MinLength(2, ErrorMessage = "must be at least 2 characters")]
    public string Body { get; set; }

    [Display(Name = "Image URL")]
    public string? ImgUrl { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;



    /*************************************************************************
    Relationship properties below

    Foreign Keys: id of a different (foreign) model
    
    Navigation Props:
        data type is a related model
        Must use the .Include for the nav prop

    *************************************************************************/

    public int UserId { get; set; } // this FK Needs to match w/ the PK property
    public User? Author { get; set; }

    // this must have a default value of an empty list because when we look through this list with a foreach loop, it will break if the List = null, but it can look through an empty list without breaking
    public List<UserPostLike> Likes { get; set; } = new List<UserPostLike>();
}
