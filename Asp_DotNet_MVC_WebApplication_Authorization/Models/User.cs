using System.ComponentModel.DataAnnotations;

namespace Asp_DotNet_MVC_WebApplication_Authorization.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    }
}