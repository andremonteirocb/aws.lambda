using Amazon.Lambda;
using Amazon.Lambda.Model;
using Amazon.KeyManagementService;
using System.IO;

namespace Lambda.Console
{
    class Program
    {
        static AmazonLambdaClient client = new AmazonLambdaClient();
        static void Main(string[] args)
        {
            const string input = "{ \"Message\": \"André Luiz Soares Alves Monteiro\" }";

            var request = new InvokeRequest()
            {
                FunctionName = "Lambda",
                Payload = input,
                InvocationType = "Event" //chamada assincroca
            };

            var response = client.InvokeAsync(request).Result;

            System.Console.WriteLine($"Result => {new StreamReader(response.Payload).ReadToEnd() }");
        }
    }
}
