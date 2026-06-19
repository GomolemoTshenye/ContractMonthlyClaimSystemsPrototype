using ContractMonthlyClaimSystemsPrototype.Models;
using System.Linq;
using System.Web.Mvc;

namespace ContractMonthlyClaimSystemsPrototype.Controllers
{
    [Authorize] // Ideally [Authorize(Roles = "Coordinator")]
    public class ApprovalController : Controller
    {
        private ClaimsContext db = new ClaimsContext();

        public ActionResult Index()
        {
            var claims = db.Claims.Where(c => c.Status == "Pending" || c.Status == "Flagged").ToList();

            // AUTOMATION 2: Verification Algorithm
            foreach (var claim in claims)
            {
                // Reset status temporarily to re-check
                if (claim.Status == "Flagged") claim.Status = "Pending";

                // Rule: If Rate > 500 OR Hours > 100, Flag it.
                if (claim.HourlyRate > 500 || claim.HoursWorked > 100)
                {
                    claim.Status = "Flagged";
                }
            }
            
            db.SaveChanges();

            return View(claims);
        }

        [HttpPost]
        public ActionResult Approve(int id)
        {
            var claim = db.Claims.Find(id);
            if (claim != null)
            {
                claim.Status = "Approved";
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Reject(int id)
        {
            var claim = db.Claims.Find(id);
            if (claim != null)
            {
                claim.Status = "Rejected";
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}