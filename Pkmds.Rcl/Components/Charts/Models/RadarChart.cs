namespace Pkmds.Rcl.Components.Charts.Models;

// a class containing the data for a chart.js radar chart
public class RadarChart
{
    public string[] Labels { get; set; } = Array.Empty<string>();
    public RadarChartDataset[] Datasets { get; set; } = Array.Empty<RadarChartDataset>();
}
