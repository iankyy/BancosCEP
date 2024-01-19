using System.Text.Json.Serialization;

namespace BancosCEP.Models
{
    public class BancoModel
    {
        [JsonPropertyName("ispb")]
        public string? Ispb { get; set; }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("code")]
        public int? Code { get; set; }
        [JsonPropertyName("fulName")]
        public string? FullName { get; set; }
    }
}

