using DataModel.Context;
using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var datacontext = new HospitalDataContext())
                {
                    var thePatientId = 410;

                    var medicalTreatment = datacontext.MedicalTreatments.Where(
                                medicalTreatment => medicalTreatment.PatientId == thePatientId);

                    var patient = datacontext.Patients.Where(patient => patient.PatientId == thePatientId).FirstOrDefault();

                    Console.WriteLine("Number of medical treatment for the patient, with PatientId = {0}, is/are {1}.",
                                        thePatientId, medicalTreatment.Count());

                    foreach (var item in medicalTreatment)
                    {
                        Console.WriteLine(string.Concat("\tMedical Treatment Id: ", item.MedicalTreatmentId,
                                                        "\tPatient Name: ", patient.Name,
                                                        "\tPatientId: ", item.PatientId,
                                                        "\tMedicine: ", item.Medicine));
                    }                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}

/*  CONSOLE OUTPUT FOR MIGRATION 20210221155333_MigrationV0.csv

Number of medical treatment for the patient, with PatientId = 410, is/are 6.
        Medical Treatment Id: 540       Patient Name: Jack      PatientId: 410  Medicine: Morfine
        Medical Treatment Id: 1004      Patient Name: Jack      PatientId: 410  Medicine: relpax
        Medical Treatment Id: 1377      Patient Name: Jack      PatientId: 410  Medicine: Dupixent
        Medical Treatment Id: 2032      Patient Name: Jack      PatientId: 410  Medicine: Sancuso
        Medical Treatment Id: 2179      Patient Name: Jack      PatientId: 410  Medicine: Sancuso
        Medical Treatment Id: 2266      Patient Name: Jack      PatientId: 410  Medicine: Paracetamol 
*/
