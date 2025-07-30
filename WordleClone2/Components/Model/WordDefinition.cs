namespace WordleClone2.Components.Model;

using System.Text.Json.Serialization;

public class WordDefinition
{
    public string Word { get; set; } = String.Empty;
    public List<Meaning> Meanings { get; set; } = [];
}

public class Definition
{
    [JsonPropertyName("definition")]
    public string Defined { get; set; } = String.Empty;
}

public class Meaning
{
    public string PartOfSpeech { get; set; } = String.Empty;
    public List<Definition> Definitions { get; set; } = [];
}
