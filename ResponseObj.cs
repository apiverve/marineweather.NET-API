using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Location data
    /// </summary>
    public class Location
    {
        [JsonProperty("lat")]
        public double Lat { get; set; }

        [JsonProperty("lon")]
        public double Lon { get; set; }

    }
    /// <summary>
    /// Weather data
    /// </summary>
    public class Weather
    {
        [JsonProperty("maxtempc")]
        public double Maxtempc { get; set; }

        [JsonProperty("maxtempf")]
        public int Maxtempf { get; set; }

        [JsonProperty("mintempc")]
        public double Mintempc { get; set; }

        [JsonProperty("mintempf")]
        public double Mintempf { get; set; }

        [JsonProperty("avgtempc")]
        public double Avgtempc { get; set; }

        [JsonProperty("avgtempf")]
        public double Avgtempf { get; set; }

        [JsonProperty("maxwindmph")]
        public int Maxwindmph { get; set; }

        [JsonProperty("maxwindkph")]
        public double Maxwindkph { get; set; }

        [JsonProperty("totalprecipmm")]
        public double Totalprecipmm { get; set; }

        [JsonProperty("totalprecipin")]
        public double Totalprecipin { get; set; }

        [JsonProperty("totalsnowcm")]
        public int Totalsnowcm { get; set; }

        [JsonProperty("avgviskm")]
        public double Avgviskm { get; set; }

        [JsonProperty("avgvismiles")]
        public int Avgvismiles { get; set; }

        [JsonProperty("moonphase")]
        public string Moonphase { get; set; }

        [JsonProperty("moonillumination")]
        public int Moonillumination { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("weather")]
        public Weather Weather { get; set; }

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
