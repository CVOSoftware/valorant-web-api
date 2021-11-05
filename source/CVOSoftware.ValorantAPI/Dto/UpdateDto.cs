using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record UpdateDto
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("author")]
        public string Author { get; init; }

        [JsonPropertyName("publish")]
        public bool Publish { get; init; }

        /// <summary>
        /// Legal values: riotclient, riotstatus, game
        /// </summary>
        [JsonPropertyName("publish_locations")]
        public string[] PublishLocations { get; init; }

        [JsonPropertyName("translations")]
        public StatusContentDto[] Translations { get; init; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; }

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; }
    }
}