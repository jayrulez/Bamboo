using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bamboo.ViewModels
{
    public class CreateUserViewModel
    {
        [JsonProperty("first_name")]
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        [DisplayName("Last Name")]
        [Required]
        public string LastName { get; set; }

        [JsonProperty("email")]
        [DisplayName("Email Address")]
        [Required]
        public string Email { get; set; }

        [JsonProperty("password")]
        [DisplayName("Password")]
        [Required]
        public string Password { get; set; }
    }
}
