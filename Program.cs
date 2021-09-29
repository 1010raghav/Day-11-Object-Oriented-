using Newtonsoft.Json;
using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            var data = fetchJsonForRice.Read("E:/Json/Rice.json");

            Console.WriteLine(JsonConvert.SerializeObject(data));
        }
    }
}
