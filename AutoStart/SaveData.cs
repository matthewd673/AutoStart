using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace AutoStart
{
    public static class SaveData
    {

        public static XDocument data;

        public static Random rng;

        public static void loadData()
        {
            if (File.Exists("launch.xml"))
                data = XDocument.Load("launch.xml");
            else
            {
                data = new XDocument(new XElement("actions"));
            }
            rng = new Random();
        }

        public static void saveData()
        {
            data.Save("launch.xml");
        }

        public static string generateId()
        {
            string id = "";

            for(int i = 0; i < 8; i++)
            {
                id += ((char)(97 + rng.Next(26))).ToString();
            }

            return id;

        }

    }
}
