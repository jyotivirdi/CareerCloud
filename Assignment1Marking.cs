using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CareerCloud.Pocos;
using System.Linq;
using System.Reflection;
using CareerCloud.UnitTests.Utils;

namespace CareerCloud.UnitTests.Assingment1Tests
{
    [TestCategory("Assignment 1 Poco Tests")]
    [TestClass]
    public class Assignment1Marking
    {
        private const string _assemblyUnderTest = "CareerCloud.Pocos.dll";

        private Type[] _types;

        [TestInitialize]
        public void Init()
        {
            // create an instance of a POCO to load the Pocos assembly
            ApplicantEducationPoco poco = new ApplicantEducationPoco();
            _types = Assembly.LoadFrom(_assemblyUnderTest).GetTypes();
        }

        [TestMethod]
        public void Assingment_1_Poco_Creation()
        {

            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantEducationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantJobApplicationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantProfilePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantResumePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantSkillPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "ApplicantWorkHistoryPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyDescriptionPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobEducationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobDescriptionPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyJobSkillPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyLocationPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "CompanyProfilePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginsLogPoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityLoginsRolePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SecurityRolePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SystemCountryCodePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "SystemLanguageCodePoco"));
            Assert.IsTrue(_types.Any(t => t.Name == "IPoco"));
        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicationEducationPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantEducationPoco");
            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));
            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Educations"));

            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CertificateDiploma"), "Certificate_Diploma"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartDate"), "Start_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompletionDate"), "Completion_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompletionPercent"), "Completion_Percent"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Major"));

        }
        [TestMethod]
        public void Assignment_1_Poco_ApplicantJobApplicationPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantJobApplicationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Job_Applications"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ApplicationDate"), "Application_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));

        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantProfilePoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantProfilePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Profiles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CurrentSalary"), "Current_Salary"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CurrentRate"), "Current_Rate"));

            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Country"), "Country_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Province"), "State_Province_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Street"), "Street_Address"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "City"), "City_Town"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Currency"));

        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantResumePoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantResumePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Resumes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Resume"));

        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantSkillPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantSkillPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Skills"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndYear"), "End_Year"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Skill"));
        }


        [TestMethod]
        public void Assignment_1_Poco_ApplicantWorkHistoryPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantWorkHistoryPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Work_History"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobTitle"), "Job_Title"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobDescription"), "Job_Description"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndYear"), "End_Year"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Location"));

        }


        [TestMethod]
        public void Assignment_1_Poco_CompanyDescriptionPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyDescriptionPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Descriptions"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyDescription"), "Company_Description"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobEducationPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobEducationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Job_Education"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Major"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Importance"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Jobs"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ProfileCreated"), "Profile_Created"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsCompanyHidden"), "Is_Company_Hidden"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobDescriptionPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobDescriptionPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Jobs_Descriptions"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobName"), "Job_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobDescriptions"), "Job_Descriptions"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobSkillPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobSkillPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Job_Skills"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Skill"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Importance"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyLocationPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyLocationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Locations"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Province"), "State_Province_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Street"), "Street_Address"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "City"), "City_Town"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyProfilePoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyProfilePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Profiles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "RegistrationDate"), "Registration_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyWebsite"), "Company_Website"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ContactPhone"), "Contact_Phone"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ContactName"), "Contact_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyLogo"), "Company_Logo"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginPoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Created"), "Created_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PasswordUpdate"), "Password_Update_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "AgreementAccepted"), "Agreement_Accepted_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsLocked"), "Is_Locked"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EmailAddress"), "Email_Address"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PhoneNumber"), "Phone_Number"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "FullName"), "Full_Name"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ForceChangePassword"), "Force_Change_Password"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PrefferredLanguage"), "Prefferred_Language"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Password"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Salt"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginsLogPoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginsLogPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins_Log"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SourceIP"), "Source_IP"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "LogonDate"), "Logon_Date"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsSuccesful"), "Is_Succesful"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginsRolePoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginsRolePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins_Roles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Role"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityRolePoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityRolePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Roles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Role"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SystemCountryCodePoco()
        {
            Type poco = GetChar.GetType(_types, "SystemCountryCodePoco");
            Assert.IsTrue(GetChar.HasTable(poco, "System_Country_Codes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Code")));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Name"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SystemLanguageCodePoco()
        {
            Type poco = GetChar.GetType(_types, "SystemLanguageCodePoco");
            Assert.IsTrue(GetChar.HasTable(poco, "System_Language_Codes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "LanguageID")));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "NativeName"), "Native_Name"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Name"));
        }
    }
}