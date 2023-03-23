namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartTooltips
{
    public ChartTooltips()
    {
        Enabled = true;
        Mode = "nearest";
        Intersect = true;
        Position = "average";
        BackgroundColor = "rgba(0,0,0,0.7)";
        TitleFontColor = "#fff";
        BodyFontColor = "#fff";
        BodySpacing = 2;
        XPadding = 6;
        YPadding = 6;
        CornerRadius = 6;
        MultiKeyBackground = "#fff";
    }
    public bool Enabled { get; set; }
    public string Mode { get; set; }
    public bool Intersect { get; set; }
    public string Position { get; set; }
    public string BackgroundColor { get; set; }
    public string TitleFontColor { get; set; }
    public string BodyFontColor { get; set; }
    public int BodySpacing { get; set; }
    public int XPadding { get; set; }
    public int YPadding { get; set; }
    public int CornerRadius { get; set; }
    public string MultiKeyBackground { get; set; }
}
