namespace MyCardiologyApp.Models;
public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
}

public class CardiacRecord
{
    public int Id { get; set; }
    public int PatientId { get; set; }
    public string Diagnosis { get; set; }
    public string TreatmentPlan { get; set; }
}