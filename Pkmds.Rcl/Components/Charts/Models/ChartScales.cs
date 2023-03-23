namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartScales
{
    public ChartScales()
    {
        XAxes = new List<ChartScale>();
        YAxes = new List<ChartScale>();
    }
    public List<ChartScale> XAxes { get; set; }
    public List<ChartScale> YAxes { get; set; }
}
