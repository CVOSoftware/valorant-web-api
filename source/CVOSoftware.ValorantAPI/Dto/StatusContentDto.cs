using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record StatusContentDto
    {
        [JsonPropertyName("locale")]
        public string Locale { get; init; }

        [JsonPropertyName("content")]
        public string Content { get; init; }
    }
}