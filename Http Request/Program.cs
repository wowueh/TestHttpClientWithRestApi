using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Http_Request
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap dia chi web: ");
            var diaChiWeb = Console.ReadLine();
            DuyetWebAsync(diaChiWeb);
            Console.WriteLine("Vui long cho ...");
            Console.ReadKey();
        }
        static async void DuyetWebAsync(string diaChiWeb)
        {
            var client = new HttpClient();
            var response = new HttpResponseMessage();
            response = await client.GetAsync(diaChiWeb);
            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine("\n" + responseContent);
            Console.ReadKey();
        }
    }
}
