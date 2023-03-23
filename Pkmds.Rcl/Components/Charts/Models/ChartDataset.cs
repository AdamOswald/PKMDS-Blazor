namespace Pkmds.Rcl.Components.Charts.Models;

public class ChartDataset
{
    public ChartDataset()
    {
        Label = "";
        Data = new List<double>();
        BackgroundColor = new List<string>();
        BorderColor = new List<string>();
        BorderWidth = 1;
        PointRadius = 3;
        PointBackgroundColor = new List<string>();
        PointBorderColor = new List<string>();
        PointBorderWidth = 1;
        PointHoverRadius = 3;
        PointHoverBackgroundColor = new List<string>();
        PointHoverBorderColor = new List<string>();
        PointHoverBorderWidth = 1;
        PointHitRadius = 1;
        PointStyle = new List<string>();
        LineTension = 0.4;
        Fill = true;
        SpanGaps = false;
        SteppedLine = false;
        CubicInterpolationMode = "default";
        Order = 0;
        XAxisID = "x-axis-0";
        YAxisID = "y-axis-0";
        ShowLine = true;
        BorderCapStyle = "butt";
        BorderDash = new List<int>();
        BorderDashOffset = 0;
        BorderJoinStyle = "miter";
        PointBorderWidth = 1;
        PointHoverRadius = 3;
        PointHoverBorderWidth = 1;
        PointHitRadius = 1;
        PointStyle = new List<string>();
        SpanGaps = false;
        SteppedLine = false;
        CubicInterpolationMode = "default";
        XAxisID = "x-axis-0";
        YAxisID = "y-axis-0";
        ShowLine = true;
        BorderCapStyle = "butt";
        BorderDash = new List<int>();
        BorderDashOffset = 0;
        BorderJoinStyle = "miter";
    }
    public string Label { get; set; }
    public List<double> Data { get; set; }
    public List<string> BackgroundColor { get; set; }
    public List<string> BorderColor { get; set; }
    public int BorderWidth { get; set; }
    public int PointRadius { get; set; }
    public List<string> PointBackgroundColor { get; set; }
    public List<string> PointBorderColor { get; set; }
    public string XAxisID { get; set; }
    public string YAxisID { get; set; }
    public bool ShowLine { get; set; }
    public string BorderCapStyle { get; set; }
    public List<int> BorderDash { get; set; }
    public int BorderDashOffset { get; set; }
    public string BorderJoinStyle { get; set; }
    public int PointBorderWidth { get; set; }
    public int Order { get; set; }
    public int PointHoverRadius { get; set; }
    public List<string> PointHoverBackgroundColor { get; set; }
    public List<string> PointHoverBorderColor { get; set; }
    public int PointHoverBorderWidth { get; set; }
    public int PointHitRadius { get; set; }
    public List<string> PointStyle { get; set; }
    public double LineTension { get; set; }
    public bool Fill { get; set; }
    public bool SpanGaps { get; set; }
    public bool SteppedLine { get; set; }
    public string CubicInterpolationMode { get; set; }
}
