using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record PlatformDataDto
    {
        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("name")]
        public string Name { get; init; }

        [JsonPropertyName("locales")]
        public string[] Locales { get; init; }

        [JsonPropertyName("maintenances")]
        public StatusDto[] Maintenances { get; init; }

        [JsonPropertyName("incidents")]
        public StatusDto[] Incidents { get; init; }
    }
}