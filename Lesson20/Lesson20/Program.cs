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

        // Якщо необхідно передати параметри, використовуйте QueryString:
        // string urlWithParams = $"{url}?param1=value1&param2=value2";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
    }

    static async Task SendPostRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        // Приклад створення об'єкту для передачі у POST-запиті
        // var requestData = new { Name = "John", Age = 30 };

        // Для передачі параметрів через тіло запиту, використовуйте `HttpClient` і `PostAsync`
        // HttpResponseMessage response = await client.PostAsync(url, new StringContent(JsonConvert.SerializeObject(requestData), Encoding.UTF8, "application/json"));

        Console.WriteLine("POST-запит не реалізовано в прикладі.");
    }

    static async Task SendPutRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        Console.WriteLine("PUT-запит не реалізовано в прикладі.");
    }

    static async Task SendDeleteRequest()
    {
        Console.Write("URL: ");
        string url = Console.ReadLine();

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.DeleteAsync(url);
            string responseBody = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseBody);
        }
    }
}