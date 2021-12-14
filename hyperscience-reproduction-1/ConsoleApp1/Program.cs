using System;
using System.Collections.Generic;
using System.IO;
using Hyperscience.Saas.Config;
using Hyperscience.Saas.Service.Api;
using Hyperscience.Saas.Service.Api.Enum;
using Hyperscience.Saas.Service.Auth.Model.Credentials;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsettings.json", false)
                .Build();

            var client = new ApiController(
                new Configuration(configuration["domain"]),
                new CredentialsProvider(
                    configuration["client_id"],
                    configuration["client_secret"]
                )
            );
            var versionResponse = client.Get("api/v5/version");
            var version = versionResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(version);

            var pathToFile = "path_to_file_for_upload";
            pathToFile = "C:\\Users\\stjim\\Downloads\\1806197315 - 1831798085 - HB1989622.pdf";

            var submissionResponse = client.Post("api/v5/submissions", new List<KeyValuePair<string, string>>
            {
                new("file", pathToFile),
                new("metadata", JsonConvert.SerializeObject(new {Id = "test"}))
            }, SupportedContentType.MultipartFormData);
            var submission = submissionResponse.Content.ReadAsStringAsync().Result;

            Console.WriteLine(submission);
        }
    }
}