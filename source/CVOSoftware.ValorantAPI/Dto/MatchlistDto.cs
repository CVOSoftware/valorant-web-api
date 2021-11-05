using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record MatchlistDto
    {
        [JsonPropertyName("puuid")]
        public string Puuid { get; init; }

        [JsonPropertyName("history")]
        public MatchlistEntryDto[] History { get; init; }
    }
}