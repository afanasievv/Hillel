using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Виберіть тип запиту:");
            Console.WriteLine("1. GET");
            Console.WriteLine("2. POST");
            Console.WriteLine("3. PUT");
            Console.WriteLine("4. DELETE");
            Console.WriteLine("5. Вийти");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await SendGetRequest();
                    break;
                case "2":
                    await SendPostRequest();
                    break;
                case "3":
                    await SendPutRequest();
                    break;
                case "4":
                    await SendDeleteRequest();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Недійсний вибір. Спробуйте ще раз.");
                    break;
            }
        }
    }

    static async Task SendGetRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "param1", "value1" },
            { "param2", "value2" }
        };

        string fullUrl = url + "?" + BuildQueryString(parameters);

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(fullUrl);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:");
            Console.WriteLine(responseBody);
        }
    }

    static async Task SendPostRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "param1", "value1" },
            { "param2", "value2" }
        };

        using (HttpClient client = new HttpClient())
        {
            HttpContent content = new FormUrlEncodedContent(parameters);

            HttpResponseMessage response = await client.PostAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:");
            Console.WriteLine(responseBody);
        }

    }

    static async Task SendPutRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "param1", "value1" },
            { "param2", "value2" }
        };

        using (HttpClient client = new HttpClient())
        {
            HttpContent content = new FormUrlEncodedContent(parameters);

            HttpResponseMessage response = await client.PutAsync(url, content);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:");
            Console.WriteLine(responseBody);
        }
    }

    static async Task SendDeleteRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        Dictionary<string, string> parameters = new Dictionary<string, string>
        {
            { "param1", "value1" },
            { "param2", "value2" }
        };

        
        string fullUrl = url + "?" + BuildQueryString(parameters);

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.DeleteAsync(fullUrl);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine("Response:");
            Console.WriteLine(responseBody);
        }

    }
    static string BuildQueryString(Dictionary<string, string> parameters)
    {
        var queryParameters = new List<string>();
        foreach (var kvp in parameters)
        {
            queryParameters.Add($"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}");
        }
        return string.Join("&", queryParameters);
    }
}