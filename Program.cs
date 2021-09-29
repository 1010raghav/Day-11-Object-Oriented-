using Newtonsoft.Json;
using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();

            var data = fetchJsonForRice.Read("E:/bidgelabz/Day11 Object Oriented Practice/Rice.JSON");
            Console.WriteLine(JsonConvert.SerializeObject(data));

            FetchJsonForWheat fetchJsonForWheat = new FetchJsonForWheat();

            var data1 = fetchJsonForWheat.Read("E:/bidgelabzDay11 Object Oriented Practice/Wheat.JSON");
            Console.WriteLine(JsonConvert.SerializeObject(data1));

            FetchJsonForPulses fetchJsonForPulses = new FetchJsonForPulses();

            var data2 = fetchJsonForPulses.Read("E:/bidgelabz/Day11 Object Oriented Practice/Pulses.JSON");
            Console.WriteLine(JsonConvert.SerializeObject(data2));
        
        }
    }
}
