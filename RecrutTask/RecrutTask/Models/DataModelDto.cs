using Newtonsoft.Json;

/// <summary>
/// Im declare here a DTO models and using attribute JsonProperty as string from funtranslation api
/// </summary>
/// 


namespace RecrutTask.Models
{
    public class DataModelDto
    {
        [JsonProperty("text")]
        public string InputString { get; set; }

        [JsonProperty("translated")]
        public string TranslatedString { get; set; }
    }

    public class DataModelObjectDto
    {
        [JsonProperty("contents")]
        public DataModelDto Contents { get; set; }
    }
}