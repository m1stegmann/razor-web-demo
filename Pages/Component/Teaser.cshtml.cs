using Microsoft.AspNetCore.Mvc.RazorPages;

public class TeaserModel : PageModel
{
    public (string Title, string Content) Teaser { get; set; }

    public void OnGet()
    {
        Teaser = ("Demo", "Dies ist ein Beispiel-Teaser.");
    }
}
