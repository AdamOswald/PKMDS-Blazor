namespace Pkmds.Rcl.Components.Charts.Models;

// a class containing the data for a chart.js radar chart dataset
public class RadarChartDataset
{
    public string Label { get; set; } = string.Empty;
    public string[] Data { get; set; } = Array.Empty<string>();
    public string BackgroundColor { get; set; } = string.Empty;
    public string BorderColor { get; set; } = string.Empty;
    public int BorderWidth { get; set; } = 1;
    public bool Fill { get; set; } = true;
}
