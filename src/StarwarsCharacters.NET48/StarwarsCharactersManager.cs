using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StarwarsCharacters.NET48
{
    [System.Runtime.InteropServices.Guid("d2f038b6-63cc-42c6-809a-61fe9ee22838")]
    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.ProgId("StarwarsCharacters.NET48.StarwarsCharactersManager")]
    public class StarwarsCharactersManager
    {

        private readonly List<Jedi> _jedis = new List<Jedi>() 
        { 
            new Jedi(1, "Anakin Skywalker"),
            new Jedi(2, "Dooku"),
            new Jedi(3, "Luke Skywalker"),
            new Jedi(4, "Mace Windu"),
            new Jedi(5, "Obi-Wan Kenobi"),
            new Jedi(6, "Yoda")
        };

        public Jedi GetRandom()
        {
            var random = new Random();
            int index = random.Next(_jedis.Count);
            return _jedis[index];
        }

        public Jedi Get(int id)
        {
            var query = from j in _jedis
                        where j.Id == id
                        select j;

            return query.FirstOrDefault();
        }

        public string GetInfo() {
            return $"{GetAssemblyVersionInfo()}";
        }

        public static string GetAssemblyVersionInfo()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            var fileVersion = FileVersionInfo.GetVersionInfo(assembly.Location);
            return $"{fileVersion.ProductName} version {fileVersion.FileVersion}";
        }
    }
}
