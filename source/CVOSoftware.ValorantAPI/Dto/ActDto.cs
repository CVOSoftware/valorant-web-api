using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record ActDto
    {
        [JsonPropertyName("id")]
        public string Id { get; init; }

        [JsonPropertyName("name	")]
        public string Name { get; init; }

        /// <summary>
        /// This field is excluded from the response when a locale is set.
        /// </summary>
        [JsonPropertyName("localizedNames")]
        public LocalizedNamesDto LocalizedNames { get; init; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; init; }
    }
}