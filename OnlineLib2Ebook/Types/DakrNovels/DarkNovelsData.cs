using System.Text.Json.Serialization;

namespace OnlineLib2Ebook.Types.DakrNovels; 

public class DarkNovelsData<T> {
    [JsonPropertyName("status")]
    public string Status { get; set; }
        
    [JsonPropertyName("data")]
    public T Data { get; set; }
}