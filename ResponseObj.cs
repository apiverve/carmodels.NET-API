using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class cars
{
    [JsonProperty("Make")]
    public string make { get; set; }

    [JsonProperty("CityMPG")]
    public string cityMPG { get; set; }

    [JsonProperty("CityELEC")]
    public string cityELEC { get; set; }

    [JsonProperty("CombMPG")]
    public string combMPG { get; set; }

    [JsonProperty("CombELEC")]
    public string combELEC { get; set; }

    [JsonProperty("Cyl")]
    public string cyl { get; set; }

    [JsonProperty("Displace")]
    public string displace { get; set; }

    [JsonProperty("Drive")]
    public string drive { get; set; }

    [JsonProperty("Fuel")]
    public string fuel { get; set; }

    [JsonProperty("HighwELEC")]
    public string highwELEC { get; set; }

    [JsonProperty("HighwMPG")]
    public string highwMPG { get; set; }

    [JsonProperty("Trans")]
    public string trans { get; set; }

    [JsonProperty("Size")]
    public string size { get; set; }

    [JsonProperty("Year")]
    public string year { get; set; }

    [JsonProperty("Trim")]
    public string trim { get; set; }

    [JsonProperty("Model")]
    public string model { get; set; }

}

public class data
{
    [JsonProperty("count")]
    public int count { get; set; }

    [JsonProperty("filteredOn")]
    public string[] filteredOn { get; set; }

    [JsonProperty("cars")]
    public cars[] cars { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
