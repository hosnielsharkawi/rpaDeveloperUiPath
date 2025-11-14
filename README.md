# UiPath - ACME System - Client Security Hash Automation.
![RPA](https://img.shields.io/badge/RPA-UiPath-blue?style=for-the-badge&logo=uipath)
![Status](https://img.shields.io/badge/Status-Completed-brightgreen?style=for-the-badge)

---

## 📌 Project Overview
This project automates the **Client Security Hash** assignment in **ACME System**, following the standards and structure taught in the **UiPath Academy Professional RPA Developer Certification**.

The automation:
- Logs into ACME System 1
- Extracts Work Items of type **WI5**
- Extracts client details for each item (ID, Name, Country)
- Generates a **SHA1 Security Hash** using coded workflow (C#)
- Updates the Work Items with the generated hash
- Generates a final Excel report

---

## 🚀 Technologies Used
| Category | Technology |
|---------|------------|
| Browser Automation | Edge Windows 11 |
| RPA Platform | UiPath Studio |
| UI Automation | Modern Activities |
| Data Manipulation | DataTables, LINQ |
| Coded Workflows | C# (.NET) |
| Excel Processing | Workbook activities |
| Error Handling | Try-Catch, Business & System Exception handling |
| Orchestrator Integration | Assets for Credentials, Config Dictionary |

---

---

## 🔐 Credentials & Configurations
| Setting | Where |
|--------|------|
| ACME URLs | Config.xlsx |
| Credentials | Orchestrator Asset |
| Report File Path | Config.xlsx |
| Retry Settings | Config.xlsx |

Config is loaded into a Dictionary:  
`Dictionary<String, Object> in_Config`

---

## 🧩 Key Workflows
| Workflow | Responsibility |
|---------|----------------|
| InitConfig.xaml | Load Config & Initialize Dictionary |
| OpenBrowserAcme.xaml | Launch browser + retry mechanism |
| ExtractWorkItemTable.xaml | Filter WI5 items into a DataTable |
| ExtractAndHashEachClientData.xaml | Loop through each item, extract client details, compute hash |
| UpdateEachClient.xaml | Updates ACME Work Item |
| GenerateReport.xaml | Build Excel output report |
| CloseAcmeBrowser.xaml | Clean termination |

---


## ⚙️ How to Run
1. Ensure Browser Automation is Edge on Windows 11
2. Update the **Config.xlsx** values
3. Run **Main.xaml** from UiPath Studio
4. Robot handles the full workflow automatically


## 🧠 Features

-  Full automation of **End-to-End business process**
-  Secure hash generation using **SHA1**
-  Robust Error Handling including:
    - Business Rule Exception
    - System Exception
    - Retry Logic
-  Clean project structure & organized workflow separation
-  No hard-coded values — fully **Config-driven design**
-  Modular & scalable workflows (**REFramework-like architecture**)

---

## 👤 Author

**Hosni** – RPA Developer  
💼 LinkedIn: [linkedin.com/in/hosnielsharkawi](https://linkedin.com/in/hosnielsharkawi)

This automation solution was implemented as part of the **UiPath Academy Professional RPA Developer Certification**, following best practices in secure data processing, modular workflow architecture, and robust exception handling.  
Feel free to clone.
