using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record MatchDto
    {
        [JsonPropertyName("matchInfo")]
        public MatchInfoDto MatchInfo { get; init; }

        [JsonPropertyName("players")]
        public PlayerDto[] Players { get; init; }

        [JsonPropertyName("coaches")]
        public CoachDto[] Coaches { get; init; }

        [JsonPropertyName("teams")]
        public TeamDto[] Teams { get; init; }

        [JsonPropertyName("roundResults")]
        public RoundResultDto[] RoundResults { get; init; }
    }
}