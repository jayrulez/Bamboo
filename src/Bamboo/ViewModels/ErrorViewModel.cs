using Newtonsoft.Json;
using System.ComponentModel;

namespace Bamboo.ViewModels
{
    public class ErrorViewModel
    {
        [JsonProperty("error")]
        [DisplayName("Error")]
        public string Error { get; set; }

        [DisplayName("Error Description")]
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
