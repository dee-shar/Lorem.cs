# Lorem.cs
Web-API for [lorem-api.com](https://lorem-api.com/) which provides a collection of REST, GraphQL, WebSocket, and MCP endpoints that return consistent dummy data for testing and prototyping.

## Example
```cs
using LoremApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new Lorem();
            string loremText = await api.GetLoremText();
            Console.WriteLine(loremText);
        }
    }
}
```
