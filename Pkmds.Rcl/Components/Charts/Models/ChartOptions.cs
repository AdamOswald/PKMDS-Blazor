namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartOptions
{
    public ChartOptions()
    {
        Legend = new ChartLegend();
        Title = new ChartTitle();
        Tooltips = new ChartTooltips();
        Layout = new ChartLayout();
        Scales = new ChartScales();
    }
    public ChartLegend Legend { get; set; }
    public ChartTitle Title { get; set; }
    public ChartTooltips Tooltips { get; set; }
    public ChartLayout Layout { get; set; }
    public ChartScales Scales { get; set; }
}
