using Newtonsoft.Json;
using System.ComponentModel;

namespace Bamboo.ViewModels
{
    public class UserViewModel
    {
        [JsonProperty("first_name")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        [DisplayName("Email Address")]
        public string Email { get; set; }
    }
}
