namespace Pkmds.Rcl.Components.Charts.Models;

// a class containing the configuration for a chart.js chart
public class ChartModel
{
    public string Type { get; set; } = string.Empty;
    public string[] Labels { get; set; } = Array.Empty<string>();
    public ChartDataset[] Datasets { get; set; } = Array.Empty<ChartDataset>();
    public ChartOptions Options { get; set; } = new ChartOptions();
}
