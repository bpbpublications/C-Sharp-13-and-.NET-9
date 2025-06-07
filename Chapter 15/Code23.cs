using OrthopedicClinic.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrthopedicClinic.Services;
public class PatientService
{
    private static List<Patient> patients = new List<Patient>
    {
        new Patient
        {
            Id = 1,
            Name = "John Doe",
            Age = 30,
            Condition = "Knee Pain"
        },
    };
    public List<Patient> GetAllPatients() => patients;
    public void AddPatient(Patient patient)
    {
        patient.Id = patients.Max(p => p.Id) + 1;
        patients.Add(patient);
    }

    public void UpdatePatient(Patient patient)
    {
        var index = patients.FindIndex(p => p.Id == patient.Id);
        if (index != -1)
            patients[index] = patient;
    }

    public void DeletePatient(int id)
    {
        var patient = patients.FirstOrDefault(p => p.Id == id);
        if (patient != null)
            patients.Remove(patient);
    }
}