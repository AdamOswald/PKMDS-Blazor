namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartTitle
{
    public ChartTitle()
    {
        Display = true;
        FontSize = 20;
        FontColor = "#000000";
        FontFamily = "Arial";
        Padding = 10;
        LineHeight = 1.2;
    }
    public bool Display { get; set; }
    public int FontSize { get; set; }
    public string FontColor { get; set; }
    public string FontFamily { get; set; }
    public int Padding { get; set; }
    public double LineHeight { get; set; }
}
