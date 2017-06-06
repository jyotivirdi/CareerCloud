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


            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CertificateDiploma"), "Certificate_Diploma"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CertificateDiploma"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartDate"), "Start_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime?), "StartDate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompletionDate"), "Completion_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime?), "CompletionDate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompletionPercent"), "Completion_Percent"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte?), "CompletionPercent"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Major"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Major"));

        }
        [TestMethod]
        public void Assignment_1_Poco_ApplicantJobApplicationPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantJobApplicationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Job_Applications"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ApplicationDate"), "Application_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime), "ApplicationDate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Job"));

        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantProfilePoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantProfilePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Profiles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CurrentSalary"), "Current_Salary"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(decimal?), "CurrentSalary"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CurrentRate"), "Current_Rate"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(decimal?), "CurrentRate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Country"), "Country_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Country"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Province"), "State_Province_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Province"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Street"), "Street_Address"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Street"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "City"), "City_Town"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "City"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "PostalCode"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Currency"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Currency"));
        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantResumePoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantResumePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Resumes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Resume"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Resume"));

        }

        [TestMethod]
        public void Assignment_1_Poco_ApplicantSkillPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantSkillPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Skills"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "SkillLevel"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte), "StartMonth"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(int), "StartYear"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte), "EndMonth"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndYear"), "End_Year"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(int), "EndYear"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Applicant"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Applicant"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Skill"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Skill"));
        }


        [TestMethod]
        public void Assignment_1_Poco_ApplicantWorkHistoryPoco()
        {
            Type poco = GetChar.GetType(_types, "ApplicantWorkHistoryPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Applicant_Work_History"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CompanyName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CountryCode"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CompanyName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobTitle"), "Job_Title"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "JobTitle"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobDescription"), "Job_Description"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "JobDescription"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartMonth"), "Start_Month"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(short), "StartMonth"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "StartYear"), "Start_Year"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(int), "StartYear"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndMonth"), "End_Month"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(short), "EndMonth"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EndYear"), "End_Year"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(int), "EndYear"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

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
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));

            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyName"), "Company_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CompanyName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyDescription"), "Company_Description"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CompanyDescription"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Company"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "LanguageId"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "LanguageId"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobEducationPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobEducationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Job_Educations"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Job"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Major"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Major"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Importance"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Int16), "Importance"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Jobs"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ProfileCreated"), "Profile_Created"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime), "ProfileCreated"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsInactive"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsCompanyHidden"), "Is_Company_Hidden"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsCompanyHidden"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Company"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobDescriptionPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobDescriptionPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Jobs_Descriptions"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobName"), "Job_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "JobName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "JobDescriptions"), "Job_Descriptions"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "JobDescriptions"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Job"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyJobSkillPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyJobSkillPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Job_Skills"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SkillLevel"), "Skill_Level"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "SkillLevel"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Skill"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Skill"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Importance"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(int), "Importance"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Job"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Job"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyLocationPoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyLocationPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Locations"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CountryCode"), "Country_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CountryCode"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Province"), "State_Province_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Province"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Street"), "Street_Address"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Street"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "City"), "City_Town"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "City"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PostalCode"), "Zip_Postal_Code"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "PostalCode"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Company"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Company"));
        }

        [TestMethod]
        public void Assignment_1_Poco_CompanyProfilePoco()
        {
            Type poco = GetChar.GetType(_types, "CompanyProfilePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Company_Profiles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "RegistrationDate"), "Registration_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime), "RegistrationDate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyWebsite"), "Company_Website"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "CompanyWebsite"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ContactPhone"), "Contact_Phone"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "ContactPhone"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ContactName"), "Contact_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "ContactName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "CompanyLogo"), "Company_Logo"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "CompanyLogo"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginPoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "Created"), "Created_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime), "Created"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PasswordUpdate"), "Password_Update_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime?), "PasswordUpdate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "AgreementAccepted"), "Agreement_Accepted_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime?), "AgreementAccepted"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsLocked"), "Is_Locked"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsLocked"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsInactive"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "EmailAddress"), "Email_Address"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "EmailAddress"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PhoneNumber"), "Phone_Number"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "PhoneNumber"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "FullName"), "Full_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "FullName"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "ForceChangePassword"), "Force_Change_Password"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "ForceChangePassword"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "PrefferredLanguage"), "Prefferred_Language"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "PrefferredLanguage"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Password"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Password"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginsLogPoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginsLogPoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins_Log"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "SourceIP"), "Source_IP"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "SourceIP"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "LogonDate"), "Logon_Date"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(DateTime), "LogonDate"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsSuccesful"), "Is_Succesful"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsSuccesful"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Login"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityLoginsRolePoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityLoginsRolePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Logins_Roles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "TimeStamp"), "Time_Stamp"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(byte[]), "TimeStamp"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Login"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Login"));
            Assert.IsNotNull(GetChar.GetProperty(poco, "Role"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Role"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SecurityRolePoco()
        {
            Type poco = GetChar.GetType(_types, "SecurityRolePoco");

            Assert.IsTrue(GetChar.ImplementsInterface(poco, "IPoco"));

            Assert.IsTrue(GetChar.HasTable(poco, "Security_Roles"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Id")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(Guid), "Id"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "IsInactive"), "Is_Inactive"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(bool), "IsInactive"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Role"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Role"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SystemCountryCodePoco()
        {
            Type poco = GetChar.GetType(_types, "SystemCountryCodePoco");
            Assert.IsTrue(GetChar.HasTable(poco, "System_Country_Codes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "Code")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Code"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Name"));
        }

        [TestMethod]
        public void Assignment_1_Poco_SystemLanguageCodePoco()
        {
            Type poco = GetChar.GetType(_types, "SystemLanguageCodePoco");
            Assert.IsTrue(GetChar.HasTable(poco, "System_Language_Codes"));
            Assert.IsTrue(GetChar.HasKey(GetChar.GetProperty(poco, "LanguageID")));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "LanguageID"));
            Assert.IsTrue(GetChar.HasColumn(GetChar.GetProperty(poco, "NativeName"), "Native_Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "NativeName"));

            Assert.IsNotNull(GetChar.GetProperty(poco, "Name"));
            Assert.IsTrue(GetChar.GetPropertyType(poco, typeof(string), "Name"));
        }
    }
}