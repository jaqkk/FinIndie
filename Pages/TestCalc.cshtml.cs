using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FinIndie.Pages
{
	public class CalcModel : PageModel
	{
		private readonly ILogger<CalcModel> _logger;

		public CalcModel(ILogger<CalcModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}