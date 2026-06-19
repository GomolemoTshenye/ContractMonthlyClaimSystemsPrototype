using System;
using System.ComponentModel.DataAnnotations;

namespace ContractMonthlyClaimSystemsPrototype.Models
{
    public class Claim
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Lecturer Email")]
        public string LecturerId { get; set; }

        [Required(ErrorMessage = "Please select a month.")]
        public string Month { get; set; }

        [Required(ErrorMessage = "Hours worked is required.")]
        [Range(1, 200, ErrorMessage = "Hours must be between 1 and 200.")]
        [Display(Name = "Hours Worked")]
        public double HoursWorked { get; set; }

        [Required(ErrorMessage = "Hourly rate is required.")]
        [Range(1, 1000, ErrorMessage = "Rate must be between R1 and R1000.")]
        [Display(Name = "Hourly Rate")]
        public double HourlyRate { get; set; }

        [Display(Name = "Total Amount")]
        public double Amount
        {
            get { return HoursWorked * HourlyRate; }
        }

        [Display(Name = "Supporting Document")]
        public string DocumentPath { get; set; }

        [Display(Name = "Notes")]
        public string AdditionalNotes { get; set; }

        public string Status { get; set; } = "Pending"; 

        public DateTime SubmissionDate { get; set; } = DateTime.Now;
    }
}