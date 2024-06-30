using HtmlAgilityPack;
using Newtonsoft.Json;

string url = "https://www.linkedin.com/";

HtmlWeb web = new();
HtmlDocument document = web.Load(url);

List<string> linksList = [];

HtmlNodeCollection links = document.DocumentNode.SelectNodes("//a[@href]");

if (links != null)
{
    foreach (HtmlNode link in links)
    {
        Console.WriteLine(link.Attributes["href"].Value);
    }

    string jsonOutput = JsonConvert.SerializeObject(linksList,  Formatting.Indented);
    Console.WriteLine(jsonOutput);
}
else
{
    Console.WriteLine("Nenhum link encontrado.");
}