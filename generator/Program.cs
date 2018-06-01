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
using ml.generator.kaggle.datasetinfo;
using System.Linq;
using System.Text;

namespace ml.generator
{
    class Program
    {
        // {57FD0AF1-C8A5-42F7-8557-F45027135C55}
        static Guid identity = new Guid("57FD0AF1-C8A5-42F7-8557-F45027135C55");

        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "bmVwb211Y2VubzoyYTQ0NDFmZGRmNzA0NGE1YTU1OGUzNTlkMTQwMjgyZg==");
            client.BaseAddress = new Uri("https://www.kaggle.com/api/v1");
            var datasources = new Symbol()
            {
                Choices = new List<ChoiceElement>(),
                Datatype = "choice",
                Description = "Datasource reference",
                Type = SymbolType.Parameter
            };
            StringBuilder sbProperties = new StringBuilder();
            StringBuilder sbColumns= new StringBuilder();
            StringBuilder sbFileDownload = new StringBuilder();

            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine($"Get page {i}");
                var content = await client.GetStringAsync($"https://www.kaggle.com/api/v1/datasets/list?page={i}");
                
                var datasets = Dataset.FromJson(content);

                if(datasets.Length == 0)
                {
                    Console.WriteLine($"Max page is {i}");
                    i = int.MaxValue;
                }

                foreach (var dataset in datasets)
                {
                    var dataDetails = await client.GetStringAsync($"https://www.kaggle.com/api/v1/datasets/view/{dataset.Ref}");
                    var datasetInfo =  DatasetInfo.FromJson(dataDetails);
                    Console.WriteLine(dataDetails);
                    if (dataset.DownloadCount > 0 && datasetInfo.Files.Any(f => f.FileType == ".csv"))
                    {
                        sbProperties.AppendLine($"#if (datasource == \"{datasetInfo.Ref}\")");
                        sbColumns.AppendLine($"#if (datasource == \"{datasetInfo.Ref}\")");
                        sbFileDownload.AppendLine($"#if (datasource == \"{datasetInfo.Ref}\")");
                        sbProperties.AppendLine();
                        var factsContent = datasetInfo.Files.Max(f => f.TotalBytes);

                        var factsFile = datasetInfo.Files.Single(f => f.TotalBytes == factsContent);
                        var download = $"var fileContent = client.GetStringAsync(\"https://www.kaggle.com/api/v1/datasets/download/{datasetInfo.Ref}/{factsFile.Name}\").Result;";
                        sbFileDownload.AppendLine(download);
                        sbColumns.Append(string.Join(",\n", factsFile.Columns.Select(c => $"\t\t\t\"{c.Name}\"")));
                        foreach (var factColumn in factsFile.Columns)
                        {
                            string type = string.Empty;
                            switch (factColumn.Type)
                            {
                                case ColumnType.Numeric:
                                    type = "float";
                                    break;
                                case ColumnType.String:
                                    type = "string";
                                    break;
                                case ColumnType.Boolean:
                                    type = "bool";
                                    break;
                                case ColumnType.DateTime:
                                    type = "DateTime";
                                    break;
                                default:
                                    type = "string";
                                    break;
                            }

                            sbProperties.AppendLine($"\t\t//Description: {factColumn.Description}");
                            sbProperties.AppendLine($"\t\t[Column(ordinal: \"{factColumn.Order}\")]");
                            sbProperties.AppendLine($"\t\tpublic {type} {factColumn.Name}");
                            sbProperties.AppendLine();
                        }
                        sbProperties.AppendLine();
                        sbProperties.AppendLine("#endif");

                        sbColumns.AppendLine();
                        sbColumns.AppendLine("#endif");
                        sbFileDownload.AppendLine("#endif");


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
            }
            var programText = await  System.IO.File.ReadAllTextAsync(@"C:\mine\Projects\ml-project-template\generator\Program_template.txt");
            programText = programText.Replace(@"//FACT_PROPERTIES", sbProperties.ToString());
            programText = programText.Replace(@"//FACT_COLUMNS", sbColumns.ToString());
            programText = programText.Replace(@"//FACT_DOWNLOAD", sbFileDownload.ToString());
            if (System.IO.File.Exists(@"C:\mine\Projects\ml-project-template\template\Program.cs"))
            {
                System.IO.File.Delete(@"C:\mine\Projects\ml-project-template\template\Program.cs");
            }
            await System.IO.File.WriteAllTextAsync(@"C:\mine\Projects\ml-project-template\template\Program.cs", programText);

            Template tp = new Template();
            tp.ShortName = new ShortName()
            {
                String = "ml2"
            };
            tp.Author = "Microsoft";
            tp.Identity = identity.ToString();

            tp.Classifications = new string[] { "Console", "ML", "ML.NET", "AI" };



            tp.Name = "Machine learning sample application";
            tp.Symbols = new Dictionary<string, Symbol>();
            tp.Symbols.Add("datasource", datasources);
            tp.PostActions = new PostAction[]
            {
                new PostAction()
                {
                    ActionId = "3A7C4B45-1F5D-4A30-959A-51B88E82B5D2",
                    ManualInstructions= new ManualInstruction[]
                    {
                        new ManualInstruction()
                        {
                            Text = "rum setup.cmd"
                        }
                    },
                    Args = new Dictionary<string, string>(){ { "executable","setup.cmd" }, { "args", ""} }
                }
            }; ;
            

            var json = tp.ToJson();

            await System.IO.File.WriteAllTextAsync(@"C:\mine\Projects\ml-project-template\template\.template.config\template.json", json);



            //Console.WriteLine(tp.ToJson());
        }

        public void WriteTemplate(string consumer, string temaplate)
        {

        }

    }




}
