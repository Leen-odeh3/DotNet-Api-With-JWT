using System.ComponentModel.DataAnnotations;
namespace DotNetApiWithJWT.Api.Models;
public class AddRoleModel
{
    [Required]
    public string UserId { get; set; }

    [Required]
    public string Role { get; set; }
}
