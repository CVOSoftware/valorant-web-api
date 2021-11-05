using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record DamageDto
    {
        [JsonPropertyName("damage")]
        public int Damage { get; init; }

        [JsonPropertyName("legshots")]
        public int legshots { get; init; }

        [JsonPropertyName("bodyshots")]
        public int Bodyshots { get; init; }

        [JsonPropertyName("headshots")]
        public int Headshots { get; init; }

        [JsonPropertyName("receiver")]
        public int Receiver { get; init; }
    }   
}