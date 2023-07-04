using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
    public class user
    {
        [Required(ErrorMessage = "UserName is Required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mobile Number is Required")]
        public string MobileNumber { get; set; }
    }
}
