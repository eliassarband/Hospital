using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report;

namespace Hospital.Web.BlazorServer.Pages
{
    public class ReportShowModel : PageModel
    {
        public void OnGet()
        {
        }

		public IActionResult OnPostGetReport()
		{
			//var path = StiNetCoreHelper.MapPath(this, "Reports/Report.mrt");
			//var str = System.IO.File.ReadAllText(path);
			var report = StiReport.CreateNewReport();
			//report.LoadFromString(str);

			return StiNetCoreViewer.GetReportResult(this, report);
		}

		public IActionResult OnGetViewerEvent()
		{
			return StiNetCoreViewer.ViewerEventResult(this);
		}

		public IActionResult OnPostViewerEvent()
		{
			return StiNetCoreViewer.ViewerEventResult(this);
		}
	}
}
