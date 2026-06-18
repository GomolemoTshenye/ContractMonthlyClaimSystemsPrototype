# Contract Monthly Claim System (CMCS)

![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![ASP.NET](https://img.shields.io/badge/ASP.NET-%235C2D91.svg?style=for-the-badge&logo=.net&logoColor=white)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![jQuery](https://img.shields.io/badge/jQuery-0769AD?style=for-the-badge&logo=jquery&logoColor=white)

## Project Overview
The **Contract Monthly Claim System (CMCS)** is a comprehensive, full-stack web application designed to automate the submission, verification, approval, and reporting of monthly claims for contract lecturers. 

Built with **ASP.NET MVC 5**, **Entity Framework Code-First**, and **ASP.NET Identity**, this system enforces robust business rules and features a multi-tiered approval workflow, eliminating manual paperwork and streamlining the payroll pipeline.

### Live Roles Implemented
- **Lecturer:** Submit claims, upload supporting documents, and track approval status in real-time.
- **Programme Coordinator:** Review submissions, verify accuracy, and push recommendations up the chain.
- **Academic Manager:** Final authority to approve or reject claims with mandated audit comments.
- **HR/Finance Manager:** Access the reporting dashboard to generate and export payment reports.

---

## 🚀 Key Features

| Feature | Description |
|-------|-------------|
| **Dynamic Client-Side Calculation** | Real-time calculation of total claim amounts (`Hours × Rate`) using jQuery, providing immediate UX feedback without server round-trips. |
| **Strict Data Validation** | Dual-layer validation: Client-side visual feedback (preventing zero/negative values) and Server-side enforcement (rejecting >160 hours or >R750/hr). |
| **Multi-Tier Approval Workflow** | True hierarchical workflow where Coordinators *recommend* and Managers *approve/reject*, backed by an immutable audit trail of approver comments. |
| **Automated HR Reporting** | Dedicated HR dashboard featuring one-click Excel data exports of all approved claims utilizing **ClosedXML** for seamless payroll integration. |
| **Real-Time Status Tracking** | Implements AJAX polling to update claim statuses on the user dashboard without requiring page refreshes. |
| **Secure Document Management** | Restricted file uploads (only `.pdf`, `.docx`, `.xlsx` allowed, 5MB max limit) utilizing GUID naming conventions to mitigate security risks. |
| **Role-Based Access Control (RBAC)** | Dynamic UI rendering and endpoint protection ensuring users only access menus and actions authorized for their specific role. |

---

## 🛠️ Technical Stack

**Backend:**
- C# / ASP.NET MVC 5
- Entity Framework 6 (Code-First Migrations)
- ASP.NET Identity (Authentication & Role Management)
- SQL Server LocalDB

**Frontend:**
- HTML5 / CSS3
- Bootstrap 5 + Font Awesome
- jQuery + jQuery Unobtrusive AJAX

**Libraries & Utilities:**
- **ClosedXML:** For generating Excel (.xlsx) reports.
- **Rotativa:** For optional PDF report generation.

---

## ⚙️ Getting Started

### Prerequisites
- Visual Studio 2019/2022
- SQL Server Express / LocalDB
- .NET Framework 4.7.2+



 
