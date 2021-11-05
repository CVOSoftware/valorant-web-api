using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record MatchlistEntryDto
    {
        [JsonPropertyName("matchId")]
        public string MatchId { get; init; }

        [JsonPropertyName("teamId")]
        public string TeamId { get; init; }

        [JsonPropertyName("gameStartTimeMillis")]
        public long GameStartTimeMillis { get; init; }
    }
}