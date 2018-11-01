using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Booklist_Razor_Pages.Pages.BookList
{
    public class IndexModel : PageModel
    {
        public string someData { get; set; }

        public void OnGet()
        {
            someData = "This is first property!";

        }
    }
}