using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace Request_A_File
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hay nhap url cua File: ");
            var diaChiFile = Console.ReadLine();
            RequestFileAsync(diaChiFile);
            Console.WriteLine("Vui long cho ...");
            Console.ReadKey();
        }
        static async void RequestFileAsync(string diaChiFile)
        {
            var client = new HttpClient();
            var response = new HttpResponseMessage();
            response = await client.GetAsync(diaChiFile);
            var responseContent = await response.Content.ReadAsByteArrayAsync();
            SaveFile(responseContent);
        }
        static void SaveFile(byte[] bytearray)
        {
            var file = new FileStream("d:/file", FileMode.OpenOrCreate);
            var bw = new BinaryWriter(file);
            bw.Write(bytearray);
            bw.Flush();
            bw.Close();
            Console.WriteLine("Da luu file thanh cong!");
            Console.ReadKey();
        }
    }
}
