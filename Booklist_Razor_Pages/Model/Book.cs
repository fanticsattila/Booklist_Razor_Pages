using System.ComponentModel.DataAnnotations;

namespace Booklist_Razor_Pages.Model
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string ISBN { get; set; }

        public string Author { get; set; }
    }
}
