﻿using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NNSG
{
    class Config
    {
        private static Config instance;

        public int firstDay {get; set;}
        public int people {get; set;}
        public int food {get; set;}
        public int farmers {get; set;}

        private Config()
        {
            
        }

        public static Config getInstance()
        {
            if(instance == null){
                instance = new Config();
            }
            instance.ImportConfig();
            return instance;
        }

        private void ImportConfig()
        {
            if (!File.Exists("Config.json"))
            {
                File.WriteAllText("Config.json", JsonConvert.SerializeObject(this));
            }
            else
            {
                instance = JsonConvert.DeserializeObject<Config>(File.ReadAllText("Config.json"));
            }
        }
    }
}