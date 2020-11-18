using System.ComponentModel.DataAnnotations;

namespace EmpManagement.Models
{
    /// <summary>
    /// Login Model
    /// </summary>
    public class LoginModel
    {
        /// <summary>
        /// User Name
        /// </summary>
        [Required]
        public string UserName { get; set; }
        /// <summary>
        /// Password
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}