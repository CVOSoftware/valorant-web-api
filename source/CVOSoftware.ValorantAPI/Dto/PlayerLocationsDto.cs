using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record PlayerLocationsDto
    {
        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        [JsonPropertyName("viewRadians")]
        public float ViewRadians { get; init; }

        [JsonPropertyName("location")]
        public LocationDto Location { get; init; }
    }
}