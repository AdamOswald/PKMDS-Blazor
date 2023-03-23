namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartLayout
{
    public ChartLayout()
    {
        Padding = new ChartPadding();
    }
    public ChartPadding Padding { get; set; }
}
