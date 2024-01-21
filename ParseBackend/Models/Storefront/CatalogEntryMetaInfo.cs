﻿using Newtonsoft.Json;

namespace ParseBackend.Models.Storefront
{
    public class CatalogEntryMetaInfo
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}