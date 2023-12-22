using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebB.Data;

namespace WebB.Pages
{
    public class EditPasswordModel : PageModel
    {
		bool isEntered;
		public async Task<IActionResult> OnPostAsync(string oldP, string newP)
		{
			await isEner(oldP, newP);
			if (isEntered)
				return RedirectToPage("Settings");
			else
				return RedirectToPage();
		}

		Task isEner(string p1, string p2)
		{
			isEntered = Database.Instans.Password == p1;
			if(isEntered)
				Database.Instans.Password = p2;
			return Task.CompletedTask;
		}
	}
}
