using System.Text.Json.Serialization;

namespace Shopping.Client.Models;

public class Product
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("imageFile")]
    public string ImageFile { get; set; }

    [JsonPropertyName("price")]
    public decimal Price { get; set; }
}
