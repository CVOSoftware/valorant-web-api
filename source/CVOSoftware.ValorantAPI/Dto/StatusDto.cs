using System.Text.Json.Serialization;

namespace CVOSoftware.ValorantAPI.Dto
{
    public sealed record StatusDto
    {
        [JsonPropertyName("id")]
        public int Id { get; init; }

        /// <summary>
        /// Legal values: scheduled, in_progress, complete
        /// </summary>
        [JsonPropertyName("maintenance_status")]
        public string MaintenanceStatus { get; init; }

        /// <summary>
        /// Legal values: info, warning, critical
        /// </summary>
        [JsonPropertyName("incident_severity")]
        public string IncidentSeverity { get; init; }

        [JsonPropertyName("titles")]
        public StatusContentDto[] Titles { get; init; }

        [JsonPropertyName("updates")]
        public UpdateDto[] Updates { get; init; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; }

        [JsonPropertyName("archive_at")]
        public string ArchiveAt { get; init; }
        
        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; }

        /// <summary>
        /// Legal values: windows, macos, android, ios, ps4, xbone, switch
        /// </summary>
        [JsonPropertyName("platforms")]
        public string[] Platforms { get; init; }
    }
}