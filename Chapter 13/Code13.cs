namespace MyCardiologyApp.Models;
public class PatientCardiologyViewModel(Patient patient, List<CardiacRecord> cardiacRecords)
{
    public string Name { get; set; } = patient.Name;
    public int Age { get; set; } = patient.Age;
    public string Gender { get; set; } = patient.Gender;
    public List<CardiacRecord> CardiacRecords { get; set; } = cardiacRecords;
}