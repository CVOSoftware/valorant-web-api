using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record LocationDto
    {
        [JsonPropertyName("x")]
        public int X { get; init; }

        [JsonPropertyName("y")]
        public int Y { get; init; }
    }
}