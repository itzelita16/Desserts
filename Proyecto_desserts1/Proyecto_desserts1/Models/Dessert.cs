using System;
using Newtonsoft.Json;

namespace Proyecto_desserts1.Models
{
    public class Dessert
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Nombre { get; set; }

        [JsonProperty(PropertyName = "image")]
        public string Imagen { get; set; }
    }
}
