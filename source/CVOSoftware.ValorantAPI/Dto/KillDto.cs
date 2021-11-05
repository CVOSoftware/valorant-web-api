using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record KillDto
    {
        [JsonPropertyName("timeSinceGameStartMillis")]
        public int TimeSinceGameStartMillis { get; init; }

        [JsonPropertyName("timeSinceRoundStartMillis")]
        public int TimeSinceRoundStartMillis { get; init; }

        [JsonPropertyName("killer")]
        public string Killer { get; init; }

        [JsonPropertyName("victim")]
        public string Victim { get; init; }

        [JsonPropertyName("victimLocation")]
        public LocationDto VictimLocation { get; init; }

        [JsonPropertyName("finishingDamage")]
        public FinishingDamageDto FinishingDamage { get; init; }

        [JsonPropertyName("assistants")]
        public string[] Assistants { get; init; }

        [JsonPropertyName("playerLocations")]
        public PlayerLocationsDto[] PlayerLocations { get; init; }
    }
}