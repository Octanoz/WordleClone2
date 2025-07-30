namespace WordleClone2.Components.Services;

using System.Text.Json;
using WordleClone2.Components.Model;

public class DictionaryService(HttpClient httpClient)
{
    private readonly HttpClient httpClient = httpClient;
    public async Task<WordDefinition> GetWordDefinitionAsync(string word)
    {
        JsonSerializerOptions options = new() { PropertyNameCaseInsensitive = true };
        try
        {
            var response = await httpClient.GetStringAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{word}");
            var wordDefinitions = JsonSerializer.Deserialize<List<WordDefinition>>(response, options);

            return wordDefinitions?.FirstOrDefault() ?? new()
            {
                Word = "word not found",
                Meanings =
                [
                    new Meaning()
                    {
                        PartOfSpeech = "noun",
                        Definitions =
                        [
                            new Definition()
                            {
                                Defined = "word not found"
                            }
                        ]
                    }
                ]
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Problem with the Dictionary Service: {ex.Message}");
            return null!;
        }
    }
}
