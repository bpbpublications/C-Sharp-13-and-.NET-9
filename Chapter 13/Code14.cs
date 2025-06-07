using Microsoft.AspNetCore.Mvc;
using MyCardiologyApp.Models;
using System.Web.Mvc;

public class CardiologyController : Controller
{
    public IActionResult PatientDetails(int id)
    {
        // Assume these methods get the data from the database
        var patient = GetPatientById(id);
        var cardiacRecords = GetCardiacRecordsByPatientId(id);
        var viewModel = new PatientCardiologyViewModel(patient, cardiacRecords);
        return View(viewModel);
    }

    // Methods to get data from the database (for illustration purposes)
    private Patient GetPatientById(int id)
    {
        // Fetch the patient from the database
        // For simplicity, returning a dummy patient
        return new Patient
        {
            Id = id,
            Name = "Jane Doe",
            Age = 45,
            Gender = "Female"
        };
    }

    private List<CardiacRecord> GetCardiacRecordsByPatientId(int id)
    {
        // Fetch the cardiac records from the database
        // For simplicity, returning dummy records
        return[new CardiacRecord
        {
            Id = 1,
            PatientId = id,
            Diagnosis = "Hypertension",
            TreatmentPlan = "Medication A"
        }, new CardiacRecord
        {
            Id = 2,
            PatientId = id,
            Diagnosis = "Arrhythmia",
            TreatmentPlan = "Medication B and regular monitoring"
        }

        ];
    }
}