#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegistration.Models;

public class UserPostLike {

    [Key]
    public int UserPostLikeId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public DateTime UpdatedAt { get; set; } = DateTime.Now;





    /*************************************************************************
    Relationship properties below

    Foreign Keys: id of a different (foreign) model
    
    Navigation Props:
        data type is a related model
        Must use the .Include for the nav prop

    *************************************************************************/

    public int UserId { get; set; }
    public User? User { get; set; }


    public int PostId { get; set; }
    public Post? Post { get; set; }

}