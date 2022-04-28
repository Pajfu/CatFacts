using System;
using System.IO;
using System.Net;

namespace CatFacts
{

    public class CatFact
    {
        public CatFact(string url)
        {
            var request = WebRequest.Create(url);
            request.Method = "GET";
            using var webResponse = request.GetResponse();
            using var webStream = webResponse.GetResponseStream();

            using var reader = new StreamReader(webStream);
            var data = reader.ReadToEnd();
            Console.WriteLine(data);

        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            new CatFact("https://catfact.ninja/fact");
        }
    }
}
