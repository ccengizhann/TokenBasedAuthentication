using System.ComponentModel.DataAnnotations;

namespace TokenBasedAuth.Api.Datas.VievModels
{
    public class RegisterVM
    {
        public string FirstName { get; set; }
    
        public string LastName { get; set; }
       
        public string UserName { get; set; }
        
        public string Email { get; set; }
     
        public string Password { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
