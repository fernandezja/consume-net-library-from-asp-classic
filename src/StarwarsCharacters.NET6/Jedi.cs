
namespace StarwarsCharacters.NET6
{
    [System.Runtime.InteropServices.Guid("b4f013be-3dce-46da-b098-ecebe0736027")]
    [System.Runtime.InteropServices.ComVisible(true)]
    [System.Runtime.InteropServices.ProgId("StarwarsCharacters.NET6.Jedi")]
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
