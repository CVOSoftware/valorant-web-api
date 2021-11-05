using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record PlayerStatsDto
    {
        [JsonPropertyName("score")]
        public int Score { get; init; }

        [JsonPropertyName("roundsPlayed")]
        public int RoundsPlayed { get; init; }

        [JsonPropertyName("kills")]
        public int Kills { get; init; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; init; }

        [JsonPropertyName("assists")]
        public int Assists { get; init; }

        [JsonPropertyName("playtimeMillis")]
        public int PlaytimeMillis { get; init; }

        [JsonPropertyName("abilityCasts")]
        public AbilityCastsDto AbilityCasts { get; init; }
    }
}