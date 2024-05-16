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
    [JsonProperty("mAempc")]
    public double mAempc { get; set; }

    [JsonProperty("mAempf")]
    public double mAempf { get; set; }

    [JsonProperty("mIempc")]
    public double mIempc { get; set; }

    [JsonProperty("mIempf")]
    public double mIempf { get; set; }

    [JsonProperty("aVempc")]
    public double aVempc { get; set; }

    [JsonProperty("aVempf")]
    public double aVempf { get; set; }

    [JsonProperty("mAindmph")]
    public double mAindmph { get; set; }

    [JsonProperty("mAindkph")]
    public double mAindkph { get; set; }

    [JsonProperty("tOrecipmm")]
    public double tOrecipmm { get; set; }

    [JsonProperty("tOrecipin")]
    public double tOrecipin { get; set; }

    [JsonProperty("tOnowcm")]
    public int tOnowcm { get; set; }

    [JsonProperty("aViskm")]
    public double aViskm { get; set; }

    [JsonProperty("aVismiles")]
    public int aVismiles { get; set; }

    [JsonProperty("aVumidity")]
    public int aVumidity { get; set; }

    [JsonProperty("moonphase")]
    public string moonphase { get; set; }

    [JsonProperty("moonillumItion")]
    public int moonillumItion { get; set; }

    [JsonProperty("ismoonup")]
    public int ismoonup { get; set; }

    [JsonProperty("issunup")]
    public int issunup { get; set; }

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

}

}
