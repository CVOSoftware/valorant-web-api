using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record RoundResultDto
    {
        [JsonPropertyName("roundNum")]
        public int RoundNum { get; init; }

        [JsonPropertyName("plantRoundTime")]
        public int PlantRoundTime { get; init; }

        [JsonPropertyName("defuseRoundTime")]
        public int DefuseRoundTime { get; init; }

        [JsonPropertyName("roundResult")]
        public string RoundResult { get; init; }

        [JsonPropertyName("roundCeremony")]
        public string RoundCeremony { get; init; }

        [JsonPropertyName("winningTeam")]
        public string WinningTeam { get; init; }

        [JsonPropertyName("bombPlanter")]
        public string BombPlanter { get; init; }

        [JsonPropertyName("bombDefuser")]
        public string BombDefuser { get; init; }

        [JsonPropertyName("plantSite")]
        public string PlantSite { get; init; }

        [JsonPropertyName("roundResultCode")]
        public string RoundResultCode { get; init; }

        [JsonPropertyName("plantLocation")]
        public LocationDto PlantLocation { get; init; }

        [JsonPropertyName("defuseLocation")]
        public LocationDto DefuseLocation { get; init; }

        [JsonPropertyName("plantPlayerLocations")]
        public PlayerLocationsDto[] PlantPlayerLocations { get; init; }

        [JsonPropertyName("defusePlayerLocations")]
        public PlayerLocationsDto[] DefusePlayerLocations { get; init; }

        [JsonPropertyName("playerStats")]
        public PlayerRoundStatsDto[] PlayerStats { get; init; }
    }
}