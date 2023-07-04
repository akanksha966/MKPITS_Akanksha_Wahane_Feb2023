using System.ComponentModel.DataAnnotations;

namespace validations.Models
{
    public class usermodel
    {
        //validation name and string
        //it is a client side code data annotation
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }



        [Required(ErrorMessage = "Age is Required")]
        [Range(1, 120, ErrorMessage = "Age must be between 1-120 in years.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Email ID is Required")]//email
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect EmailFormat")]
        public string Email { get; set; }
        /// <summary>
        /// conform email
        /// </summary>

        [Required(ErrorMessage = "Confirm Email is Required")]
        [DataType(DataType.EmailAddress)]
        [System.ComponentModel.DataAnnotations.Compare("Email", ErrorMessage = "Email NotMatched")]
       public string ConfirmEmail { get; set; }






    }

}
