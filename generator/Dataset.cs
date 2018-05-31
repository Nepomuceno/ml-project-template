namespace ml.generator.kaggle
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;



    public partial class Dataset
    {
        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        [JsonProperty("creatorName")]
        public string CreatorName { get; set; }

        [JsonProperty("creatorUrl")]
        public string CreatorUrl { get; set; }

        [JsonProperty("totalBytes")]
        public long TotalBytes { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("lastUpdated")]
        public System.DateTimeOffset LastUpdated { get; set; }

        [JsonProperty("downloadCount")]
        public long DownloadCount { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("isReviewed")]
        public bool IsReviewed { get; set; }

        [JsonProperty("isFeatured")]
        public bool IsFeatured { get; set; }

        [JsonProperty("licenseName")]
        public string LicenseName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ownerName")]
        public string OwnerName { get; set; }

        [JsonProperty("ownerRef")]
        public string OwnerRef { get; set; }

        [JsonProperty("kernelCount")]
        public long KernelCount { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("topicCount")]
        public long TopicCount { get; set; }

        [JsonProperty("viewCount")]
        public long ViewCount { get; set; }

        [JsonProperty("voteCount")]
        public long VoteCount { get; set; }

        [JsonProperty("currentVersionNumber")]
        public long CurrentVersionNumber { get; set; }

        [JsonProperty("files")]
        public object[] Files { get; set; }

        [JsonProperty("versions")]
        public object[] Versions { get; set; }
    }

    public partial class Tag
    {
        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("competitionCount")]
        public long CompetitionCount { get; set; }

        [JsonProperty("datasetCount")]
        public long DatasetCount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fullPath")]
        public string FullPath { get; set; }

        [JsonProperty("isAutomatic")]
        public bool IsAutomatic { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("scriptCount")]
        public long ScriptCount { get; set; }

        [JsonProperty("totalCount")]
        public long TotalCount { get; set; }
    }

    public partial class Dataset
    {
        public static Dataset[] FromJson(string json) => JsonConvert.DeserializeObject<Dataset[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Dataset[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}