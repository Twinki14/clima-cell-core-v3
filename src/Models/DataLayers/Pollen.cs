﻿namespace ClimaCellCore.Models
{
    using Newtonsoft.Json;

    public class PollenTree
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class PollenWeed
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }

    public class PollenGrass
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }
}
