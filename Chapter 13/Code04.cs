public class ExperimentAnalysisService
{
    public string AnalyzeData(ExperimentDto experiment)
    {
        if (experiment == null)
        {
            throw new ArgumentNullException(nameof(experiment), "Analysis requires experiment data.
        }

        // Example analysis logic (can be replaced with actual analysis methods)
        var analysisResult = $"Analyzing Experiment: {experiment.Name} for disease: {experiment.Disease}.";
        // Add more complex analysis logic here
        return analysisResult;
    }
}