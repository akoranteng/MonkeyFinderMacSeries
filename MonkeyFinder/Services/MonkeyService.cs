using MonkeyFinder.Models;

namespace MonkeyFinder.Services;

using System.Net.Http.Json;

public class MonkeyService
{
    HttpClient client;

    public MonkeyService()
    {
        client = new HttpClient();
    }

    public async Task<List<Monkey>> GetMonkeysAsync()
    {
        var url = "https://montemagno.com/monkeys.json";

        return await client.GetFromJsonAsync<List<Monkey>>(url);
    }
}
