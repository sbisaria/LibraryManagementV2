using System.Text;

namespace LibraryManagement
{
    public class Book
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Author { get; set; }
        public Genere Genere { get; set; }
        public bool IsIssued { get; set; }
        public string Publication { get; set; }
        public string Edition { get; set; }

        public override string ToString()
        {
            var str = new StringBuilder();
            var name = $"Book Name : {Name}";
            var id = $"Book Id : {Id}";
            var author = $"Author Name : {Author}";
            var genere = $"Genere Status : {Genere}";
            var publication = $"Publication : {Publication}";
            var edition = $"Edition : {Edition}";

            str.Append(id).Append("\n")
                .Append(name).Append("\n")
                .Append(author).Append("\n")
                .Append(genere).Append("\n")
                .Append(publication).Append("\n")
                .Append(edition).Append("\n");
            return str.ToString();

        }
    }
}
