using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record CoachDto
    {
        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; init; }
    }
}