using Microsoft.AspNetCore.Mvc.RazorPages;

namespace web_demo.Pages.Component
{
    public class LoginModel : PageModel
    {
        public string DisplayText { get; set; } = "Login";
        public string NextStatus { get; set; } = "logout";

        public void OnGet()
        {
            var status = Request.Query["status"].ToString();
            DisplayText = status == "logout" ? "Logout" : "Login";
            NextStatus = status == "logout" ? "login" : "logout";
        }
    }
}
