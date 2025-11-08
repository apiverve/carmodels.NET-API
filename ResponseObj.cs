using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Cars data
    /// </summary>
    public class Cars
    {
        [JsonProperty("Make")]
        public string Make { get; set; }

        [JsonProperty("CityMPG")]
        public string CityMPG { get; set; }

        [JsonProperty("CityELEC")]
        public string CityELEC { get; set; }

        [JsonProperty("CombMPG")]
        public string CombMPG { get; set; }

        [JsonProperty("CombELEC")]
        public string CombELEC { get; set; }

        [JsonProperty("Cyl")]
        public string Cyl { get; set; }

        [JsonProperty("Displace")]
        public string Displace { get; set; }

        [JsonProperty("Drive")]
        public string Drive { get; set; }

        [JsonProperty("Fuel")]
        public string Fuel { get; set; }

        [JsonProperty("HighwELEC")]
        public string HighwELEC { get; set; }

        [JsonProperty("HighwMPG")]
        public string HighwMPG { get; set; }

        [JsonProperty("Trans")]
        public string Trans { get; set; }

        [JsonProperty("Size")]
        public string Size { get; set; }

        [JsonProperty("Year")]
        public string Year { get; set; }

        [JsonProperty("Trim")]
        public string Trim { get; set; }

        [JsonProperty("Model")]
        public string Model { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("filteredOn")]
        public string[] FilteredOn { get; set; }

        [JsonProperty("cars")]
        public Cars[] Cars { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
