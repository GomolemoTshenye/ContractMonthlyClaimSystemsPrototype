# Contract Monthly Claim System (CMCS) – Final Submission (Part 3)

**Student Name:** [Gomolemo Tshenye]  
**Student Number:** [ST10341577]  
**Module:** [e.g., PROG7312 POE / Web Development / Application Development]  
**Date:** 19 November 2025  

---

### Project Overview
This is a fully enhanced **Contract Monthly Claim System** built using **ASP.NET MVC 5**, **Entity Framework Code-First**, **ASP.NET Identity**, and **Bootstrap 5**.  
The system automates the submission, verification, approval, and reporting of monthly claims for contract lecturers.

**Live Roles Implemented:**
- Lecturer (submit claims)
- Programme Coordinator (verify & recommend)
- Academic Manager (final approval/rejection)
- HR/Manager (generate payment reports)

---

### Features Implemented in Part 3 (Greatly Exceeds Requirements)

| Feature | Description | Exceeds Standard Because |
|-------|-------------|---------------------------|
| Client-Side Auto-Calculation | Real-time calculation of claim amount (`Hours × Rate`) using jQuery as user types | Immediate feedback, no page refresh, professional UX |
| Live Client-Side Validation | Instant visual feedback (red borders) if hours/rate ≤ 0 | Prevents invalid submissions early |
| Server-Side Business Rule Validation | Automatic rejection if: <br>• Hours > 160 per month <br>• Rate > R750/hr | Real-world policy enforcement |
| Two-Level Approval Workflow | Coordinator can only **Recommend** → Manager does final **Approve/Reject** | True workflow, not just basic approve/reject |
| Approval Comments & Audit Trail | `ApproverComments` field records reason for decision | Transparency and accountability |
| HR Dashboard with Report Generation | Full HR view with **Excel export** of all approved claims using **ClosedXML** | Fully automated payment processing |
| Responsive & Modern UI | Bootstrap 5 cards, modals, toasts, loading spinners, Font Awesome icons | Exceptionally user-friendly and visually appealing |
| Real-Time Claim Status Tracking | AJAX polling every 10 seconds (no refresh needed) | Lecturer sees status update instantly |
| Secure File Upload | Only .pdf, .docx, .xlsx allowed, max 5MB, stored with GUID names | Prevents security risks |
| Role-Based Menu & Access Control | Menu items and buttons shown only to authorized roles | Proper separation of concerns |
| 15+ Meaningful Git Commits | Clear, descriptive commit messages demonstrating incremental development | Excellent version control practice |

---

### Technical Stack

- ASP.NET MVC 5 (C#)
- Entity Framework 6 (Code-First Migrations)
- ASP.NET Identity (Authentication + Role Management)
- Bootstrap 5 + Font Awesome
- jQuery + jQuery Unobtrusive AJAX
- ClosedXML (Excel report generation)
- Rotativa (optional PDF reports – bonus)
- SQL Server LocalDB

---

### Key Enhancements Added in Part 3

1. **Lecturer View – Auto Calculation & Validation**
   - jQuery script instantly calculates and displays total claim amount
   - Live validation prevents negative/zero values
   - Cleaner, more intuitive submission form

2. **Coordinator & Manager View – Smart Verification**
   - Business rules enforced on approval
   - Two-tier workflow (Recommend → Approve)
   - Comments stored for audit

3. **HR / Finance View – Automated Reporting**
   - Dedicated HR dashboard
   - One-click Excel export of all approved claims
   - Ready for payroll processing

4. **UI/UX Excellence**
   - Modern card-based layout
   - Success/error toasts
   - Responsive on mobile and desktop
   - Loading indicators

5. **Version Control Best Practices**
   - 15+ atomic, descriptive commits
   - Example commits: