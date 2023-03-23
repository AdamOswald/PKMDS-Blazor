namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartLegend
{
    public ChartLegend()
    {
        Position = "top";
        Align = "start";
        Reverse = false;
    }
    public string Position { get; set; }
    public string Align { get; set; }
    public bool Reverse { get; set; }
}
