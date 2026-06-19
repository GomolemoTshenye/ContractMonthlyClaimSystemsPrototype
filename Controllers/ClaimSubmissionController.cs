using ContractMonthlyClaimSystemsPrototype.Models;
using Microsoft.AspNet.Identity;
using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContractMonthlyClaimSystemsPrototype.Controllers
{
    // This handles the claim submission
    [Authorize] // Ideally [Authorize(Roles = "Lecturer")]
    public class ClaimSubmissionController : Controller
    {
        private ClaimsContext db = new ClaimsContext();

        // GET: ClaimSubmission
        public ActionResult Index()
        {
            ViewBag.Months = new SelectList(new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            return View(new Claim());
        }

        // POST: ClaimSubmission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Claim claim, HttpPostedFileBase upload)
        {
            ViewBag.Months = new SelectList(new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });

            if (ModelState.IsValid)
            {
                // AUTOMATION 1: Auto-Reject Invalid Hours
                if (claim.HoursWorked > 180)
                {
                    ModelState.AddModelError("HoursWorked", "System Alert: Claims exceeding 180 hours are automatically rejected by policy.");
                    return View(claim);
                }

                // File Upload Logic
                if (upload != null && upload.ContentLength > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + Path.GetExtension(upload.FileName);
                    var path = Path.Combine(Server.MapPath("~/Uploads/"), fileName);

                    // Ensure directory exists
                    Directory.CreateDirectory(Server.MapPath("~/Uploads/"));

                    upload.SaveAs(path);
                    claim.DocumentPath = "~/Uploads/" + fileName;
                }

                claim.LecturerId = User.Identity.GetUserName();
                claim.Status = "Pending";
                claim.SubmissionDate = DateTime.Now;

                db.Claims.Add(claim);
                db.SaveChanges();

                TempData["SuccessMessage"] = "Claim submitted successfully!";
                return RedirectToAction("Index", "Home");
            }

            return View(claim);
        }
    }
}