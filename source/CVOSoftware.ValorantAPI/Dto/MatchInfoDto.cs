using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record MatchInfoDto
    {
        [JsonPropertyName("isRanked")]
        public bool IsRanked { get; init; }

        [JsonPropertyName("isCompleted")]
        public bool IsCompleted { get; init; }

        [JsonPropertyName("gameLengthMillis")]
        public int GameLengthMillis { get; init; }

        [JsonPropertyName("gameStartMillis")]
        public long GameStartMillis { get; init; }

        [JsonPropertyName("matchId")]
        public string MatchId { get; init; }

        [JsonPropertyName("mapId")]
        public string MapId { get; init; }

        [JsonPropertyName("provisioningFlowId")]
        public string ProvisioningFlowId { get; init; }

        [JsonPropertyName("queueId")]
        public string QueueId { get; init; }

        [JsonPropertyName("seasonId")]
        public string SeasonId { get; init; }

        [JsonPropertyName("customGameName")]
        public string CustomGameName { get; init; }

        [JsonPropertyName("gameMode")]
        public string GameMode { get; init; }
    }
}