public class Experiment
{
    public int ExperimentId { get; set; }
    public string Name { get; set; }
    public string Disease { get; set; }
    public string Results { get; set; }

    public void AnalyzeData()
    {
    // Business logic for analyzing experiment data
    }

    public void UpdateResults(string newResults)
    {
        // Business logic to update experiment results
        Results = newResults;
    }
}