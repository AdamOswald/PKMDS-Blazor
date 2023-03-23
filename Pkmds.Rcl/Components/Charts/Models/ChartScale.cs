namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartScale
{
    public ChartScale()
    {
        Position = "left";
        Type = "linear";
        Ticks = new ChartTicks();
        GridLines = new ChartGridLines();
    }
    public string Position { get; set; }
    public string Type { get; set; }
    public ChartTicks Ticks { get; set; }
    public ChartGridLines GridLines { get; set; }
}
