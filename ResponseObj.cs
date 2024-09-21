using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class location
{
    [JsonProperty("lat")]
    public double lat { get; set; }

    [JsonProperty("lon")]
    public double lon { get; set; }

}

public class weather
{
    [JsonProperty("maxtempc")]
    public double maxtempc { get; set; }

    [JsonProperty("maxtempf")]
    public int maxtempf { get; set; }

    [JsonProperty("mintempc")]
    public double mintempc { get; set; }

    [JsonProperty("mintempf")]
    public double mintempf { get; set; }

    [JsonProperty("avgtempc")]
    public double avgtempc { get; set; }

    [JsonProperty("avgtempf")]
    public double avgtempf { get; set; }

    [JsonProperty("maxwindmph")]
    public int maxwindmph { get; set; }

    [JsonProperty("maxwindkph")]
    public double maxwindkph { get; set; }

    [JsonProperty("totalprecipmm")]
    public double totalprecipmm { get; set; }

    [JsonProperty("totalprecipin")]
    public double totalprecipin { get; set; }

    [JsonProperty("totalsnowcm")]
    public int totalsnowcm { get; set; }

    [JsonProperty("avgviskm")]
    public double avgviskm { get; set; }

    [JsonProperty("avgvismiles")]
    public int avgvismiles { get; set; }

    [JsonProperty("moonphase")]
    public string moonphase { get; set; }

    [JsonProperty("moonillumination")]
    public int moonillumination { get; set; }

}

public class data
{
    [JsonProperty("location")]
    public location location { get; set; }

    [JsonProperty("weather")]
    public weather weather { get; set; }

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
