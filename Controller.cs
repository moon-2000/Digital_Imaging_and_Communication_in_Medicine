using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalSystemGUI

{
    public class Controller
    {
        Controller controller;
      //  int patientIDlogin;
        string InsurnacesStatue;
        int insurnaces_statue;
        DBmanager DBmang;
        public Controller ()
        { 
            DBmang = new DBmanager();
        }
        
       public int SaveMedicalInfo( int patientID ,int bloodPressre, int Glucoselevel, int OxyLevel, int Weight)
        {
            string query = "INSERT Into MedicaInfo (Patient_ID, Blood_pressure, Glucose_level, OxygenLevel, weight) VALUES ("+patientID +",'"+ bloodPressre+ "'," +Glucoselevel +" ," + OxyLevel + " ," +Weight +" )";
            return (int)DBmang.ExecuteScalar(query);
        }
     
       public int SaveMedicalHistory(string SelectedItem){ 
            string query = "INSERT INTO MedicalHistory (diseases)" + "Values ('" + SelectedItem + "');";

            return (int)DBmang.ExecuteScalar(query);
       }

        public int savePatientData( string PatientFirstName, string PatientLastName, int PatientNationalID, int PatientAge , string PatientAddress, string PatientGender, int PatientHeight, string PatientInsurancesStatue, int PatientPhone, int EmergencyPhone)
        {
            string query = "INSERT INTO Patient (P_firstname, P_lastname, P_ID, Age, Gender, Height, address, P_phone, P_Emerge_phone, Insurance_statue)" + "Values ('" + PatientFirstName + "', '" + PatientLastName + "', " + PatientNationalID + ", " + PatientAge + ", '" + PatientAddress + "', '" + PatientGender + "', " + PatientHeight + ", '" + PatientInsurancesStatue + "', " + PatientPhone + ", " + EmergencyPhone + " );";
            return DBmang.ExecuteNonQuery(query);
        }

       
        
        // compare the given patient-id to the existing patients
        
        public string PatientInsunacesStaue(int patientID)
        {
            string query = "SELECT Insurance_status  FROM Patient  WHERE P_ID = " + patientID + ")";
            return (string)DBmang.ExecuteScalar(query);
        }
        public void setPatientIsurnaceStatue(int patientID)
        {
            InsurnacesStatue = controller.PatientInsunacesStaue(patientID);
            if(InsurnacesStatue== "Teachers Syndicate")
            {
                insurnaces_statue = 15;
            }
            else if (InsurnacesStatue == "Doctors Syndicate")
            {
                insurnaces_statue = 10;
            }
            else if (InsurnacesStatue == "Engineers Syndicate")
            {
                insurnaces_statue = 20;
            }
            else if (InsurnacesStatue == "Pharmacists Syndicate")
            {
                insurnaces_statue = 20;
            }
            else if (InsurnacesStatue == "Nursing Syndicate")
            {
                insurnaces_statue = 15;
            }
            else if (InsurnacesStatue == "Accountants Syndicate")
            {
                insurnaces_statue = 5;
            }
        }
        

        public int patientExist(int patientIDlogin)
        {
            string query = "SELECT count(*) FROM Patient WHERE (P_ID = " + patientIDlogin + ")";
            return (int) DBmang.ExecuteScalar(query);
        }

        // ExistUsername check user data 
        public int ExistUsername(string username, int userpassword)
        {
            string sqlCommandquery = "SELECT COUNT(*) from UserData WHERE (Password = " + userpassword + " AND Username = '" + username + "')";
            return (int)DBmang.ExecuteScalar(sqlCommandquery);
        }

        public int SaveRadiologicalLab(string radioName,string radioReport, Image Radioimage)
        {
            string query = "INSERT INTO Radiological_Exam (Radio_name, Radio_report, Radio_image )" + "Values ('" + radioName + ",'" + radioReport + "' , " + Radioimage+ ");";

            return DBmang.ExecuteNonQuery(query);
        }
        public int SaveLab(string labName, string HemologistReport, Image Labimage)
        {
            string query = "INSERT INTO Radiological_Exam (Lab_name, Hematologist_report, Lab_image )" + "Values ('" + labName + ",'" + HemologistReport + "' , " + Labimage + ");";

            return DBmang.ExecuteNonQuery(query);
        }
        public int SaveMedications(string medicationName,int MedicationQuantity)
        {
            string query = "INSERT INTO Medications (Med_name,med_quantity) " + "Values ('" + medicationName + "'," + MedicationQuantity + ");"; 
            return DBmang.ExecuteNonQuery(query);
        }
        public int pay(int patientID)
        { 
           string total = "SELECT SUM(*) FROM billings WHERE P_ID = patientID;";

            return (int) DBmang.ExecuteScalar(total);
        }
     

        // function to reset password
        public int ResetPassword(int newPassword)
        {
            string query = "UPDATE UserData SET Password = " +newPassword+ ";";     
                return (int) DBmang.ExecuteNonQuery(query);
        }
      
        
        public DataTable displayBilling(int patientID)
        {
            string query = "SELECT * FROM billings WHERE P_ID = "+patientID+ ";";
            return DBmang.ExecuteReader(query);
        }
        public string UserPosition(string username)
        {  
            string queryUser = "SELECT Positions FROM UserData where username='" + username + "'"; 
            return (string) DBmang.ExecuteScalar(queryUser);
        }

      public DataTable DisplayMedicalInfo(int PatientID)
        {
            string query = "SELECT * FROM MedicalInfo WHERE P_ID = "+PatientID+ ";";
            return DBmang.ExecuteReader(query);
        }

        public void TerminateConnection()
        {
            DBmang.CloseConnection();
        }
    }
}
