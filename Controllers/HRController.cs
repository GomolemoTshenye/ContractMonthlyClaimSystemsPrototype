using ContractMonthlyClaimSystemsPrototype.Models;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ContractMonthlyClaimSystemsPrototype.Controllers
{
    [Authorize] // Ideally [Authorize(Roles = "HR, Manager")]
    public class HRController : Controller
    {
        private ClaimsContext db = new ClaimsContext();

        // View Approved Claims
        public ActionResult Index()
        {
            var approvedClaims = db.Claims.Where(c => c.Status == "Approved").ToList();
            return View(approvedClaims);
        }

        // AUTOMATION 3: Generate Invoice
        public ActionResult GenerateInvoice(int id)
        {
            var claim = db.Claims.Find(id);
            if (claim == null) return HttpNotFound();

            var sb = new StringBuilder();
            sb.AppendLine("============= INVOICE =============");
            sb.AppendLine($"Claim ID:   {claim.Id}");
            sb.AppendLine($"Date:       {System.DateTime.Now}");
            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"Lecturer:   {claim.LecturerId}");
            sb.AppendLine($"Month:      {claim.Month}");
            sb.AppendLine($"Hours:      {claim.HoursWorked}");
            sb.AppendLine($"Rate:       R {claim.HourlyRate}");
            sb.AppendLine("-----------------------------------");
            sb.AppendLine($"TOTAL PAY:  R {claim.Amount}");
            sb.AppendLine("===================================");

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/plain", $"Invoice_{claim.Id}.txt");
        }
    }
}