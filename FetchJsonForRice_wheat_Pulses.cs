using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataManagement
{
    class FetchJsonForRice
    {
        public Rice Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Rice>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }

            }
        }

        public Wheat Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Wheat>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }

            }
        }

        public Pulses Read(string Path)
        {

            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<Pulses>(json);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading file");
                    return null;
                }

            }
        }
    }
}
