using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ml.generator.kaggle;
using ml.generator.template;

namespace ml.generator
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bmVwb211Y2VubzoyYTQ0NDFmZGRmNzA0NGE1YTU1OGUzNTlkMTQwMjgyZg==");
            client.BaseAddress = new Uri("https://www.kaggle.com/api/v1");

            var content = await client.GetStringAsync("https://www.kaggle.com/api/v1/datasets/list");
            var datasets = Dataset.FromJson(content);
            var datasources = new template.Symbol()
            {
                Choices = new List<ChoiceElement>(),
                Datatype = "choice",
                Description = "Datasource reference",
                Type = SymbolType.Parameter
            };

            foreach (var dataset in datasets)
            {
                if (dataset.DownloadCount > 0)
                {
                    datasources.Choices.Add(
                        new ChoiceElement()
                        {
                            ChoiceClass = new ChoiceClass()
                            {
                                Choice = dataset.Ref,
                                Description = dataset.Description
                            }
                        }
                    );
                    Console.WriteLine(dataset.Url);
                }
            }
            Template tp = new Template();
            tp.ShortName = new ShortName()
            {
                String = "ml"
            };
            tp.Author = "Microsoft";

            tp.Classifications = new string[] { "Console", "ML", "ML.NET", "AI" };

            tp.Symbols = new Dictionary<string, Symbol>();
            tp.Symbols.Add("datasource", datasources);
            Console.WriteLine(tp.ToJson());
            Console.WriteLine("Hello World!");
        }

    }




}
