using System.ComponentModel.DataAnnotations;

namespace TokenBasedAuth.Api.Datas.VievModels
{
    public class TokenRequestVM
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}
