
namespace StarwarsCharacters.NET48
{
    [System.Runtime.InteropServices.Guid("6e20ab83-ae5f-4edc-b49e-25c4fa305c86")]
    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.ProgId("StarwarsCharacters.NET48.Jedi")]
    public class Jedi
    {
        public Jedi()
        {

        }
        public Jedi(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
