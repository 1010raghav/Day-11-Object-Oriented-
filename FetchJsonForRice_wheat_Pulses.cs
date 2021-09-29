using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InventoryDataManagement
{
    class FetchJsonForRice
    {
        private object searializerSettings;

        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    var searialSettings = new JsonSearializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNameContractResolver()

                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<Rice>(json, searializerSettings);
                }catch(Exception e)
                {
                    Console.WriteLine("Problem Reading File");
                    return null;
                }
            }
        }
    }
    class FetchJsonForWheat
    {
        private object searializerSettings;

        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    var searialSettings = new JsonSearializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNameContractResolver()

                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<wheat>(json, searializerSettings);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading File");
                    return null;
                }
            }
        }
    }

    class FetchJsonForPulses
    {
        private object searializerSettings;

        public Rice Read(string Path)
        {
            using (StreamReader file = new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    var searialSettings = new JsonSearializerSettings
                    {
                        ContractResolver = new CamelCasePropertyNameContractResolver()

                    };
                    Console.WriteLine(json);
                    return JsonConvert.DeserializeObject<Pulses>(json, searializerSettings);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem Reading File");
                    return null;
                }
            }
        }
    }
}

