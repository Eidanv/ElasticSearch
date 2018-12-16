using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElasticSearch;
using Nest;

namespace ElasticSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            var settings = new ConnectionSettings(new Uri("http://localhost:9200/"))
    .DefaultIndex("country");
    


            var client = new ElasticClient(settings);
            var country = new Country
            {
                Id = 7,
                city = "New york",
                population = "2.454.456",
                area = "70.123"
            };

            var indexResponse = client.IndexDocument(country);

        }
    }

    public class Country
    {
        public int Id { get; set; }
        public string city { get; set; }
        public string population { get; set; }
        public string area { get; set; }
    }

    

}
