using System.ComponentModel.DataAnnotations;

namespace eShop.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email address")]
        [Required(ErrorMessage = "Email addres is required")]
        public string EmailAddress {  get; set; }

        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
