using Pkmds.Rcl.Components.Charts.Models;

namespace Pkmds.Rcl.Components.Charts;

public partial class RadarChart
{
    [Parameter, EditorRequired]
    public string Id { get; set; } = string.Empty;

    [Parameter]
    public List<double> Data { get; set; } = new List<double>();

    //public string[] Data { get; set; }

    //[Parameter]
    //public string[] BackgroundColor { get; set; }

    [Parameter]
    public string[] Labels { get; set; } = Array.Empty<string>();

    //[Parameter]
    //public bool BeginAtZero { get; set; } = true;

    //[Parameter]
    //public int? Min { get; set; }

    //[Parameter]
    //public int? Max { get; set; }

    //[Parameter]
    //public int? StepSize { get; set; }

    //[Parameter]
    //public bool DisplayAngleLines { get; set; } = true;

    //[Parameter]
    //public bool DisplayTicks { get; set; } = true;

    //[Parameter]
    //public int MaxTicksLimit { get; set; }

    //[Parameter]
    //public double AngleLineWidth { get; set; } = 1.0;

    //[Parameter]
    //public int TicksMin { get; set; }

    //[Parameter]
    //public int TicksMax { get; set; }

    //[Parameter]
    //public bool MajorTicksEnabled { get; set; } = true;

    private const string Radar = @"radar";

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        // Here we create an anonymous type with all the options
        // that need to be sent to Chart.js
        //var config = new
        //{
        //    Type = Radar,
        //    Options = new
        //    {
        //        Scale/*s*/ = new
        //        {
        //            //R = new
        //            //{
        //            //    Min = Min,
        //            //    Max = Max,
        //            //    BeginAtZero = BeginAtZero,
        //            AngleLines = new
        //            {
        //                Display = DisplayAngleLines,
        //                LineWidth = AngleLineWidth,
        //                // Color = "Red",
        //            },
        //            //Grid = new 
        //            //{
        //            //    Circular = true,
        //            //},
        //            Ticks = new
        //            {
        //                Major = new
        //                {
        //                    Enabled = MajorTicksEnabled
        //                },
        //                //StepSize = StepSize,
        //                Display = DisplayTicks,
        //                BeginAtZero = BeginAtZero,
        //                MaxTicksLimit = MaxTicksLimit,
        //                Min = TicksMin,
        //                Max = TicksMax,
        //                Callback = "function() {return \"\"}",
        //                Color = "rgba(0, 0, 0, 0)",
        //                BackdropColor = "rgba(0, 0, 0, 0)",
        //            },
        //            //},
        //        },
        //        //Scale = new
        //        //{
        //        //    Ticks = new
        //        //    {
        //        //        BeginAtZero = BeginAtZero,
        //        //        Max = Max,
        //        //        Min = Min,
        //        //        StepSize = StepSize,
        //        //    },
        //        //},
        //        //MaintainAspectRatio = false,
        //        Plugins = new
        //        {
        //            Legend = new
        //            {
        //                Display = false,
        //            },
        //        },
        //        Elements = new
        //        {
        //            Line = new
        //            {
        //                BorderWidth = 3,
        //            },
        //        },
        //        //Responsive = true,
        //        //Scales = new
        //        //{
        //        //    YAxes = new[]
        //        //    {
        //        //        new
        //        //        {
        //        //            Ticks = new
        //        //            {
        //        //                BeginAtZero = true
        //        //            }
        //        //        }
        //        //    }
        //        //}
        //    },
        //    Data = new
        //    {
        //        Datasets = new[]
        //        {
        //            new
        //            {
        //                Data = Data,
        //                BackgroundColor = BackgroundColor,
        //                // Label = ""
        //            },
        //        },
        //        Labels = Labels,
        //    },
        //};

        var chartConfig = new ChartModel
        {
            Type = Radar,
            Labels = Labels,
            Datasets = new ChartDataset[]
            {
                new ChartDataset
                {
                    Data = Data,
                },
            },
            Options = new ChartOptions
            {
                Layout = new ChartLayout
                {

                },
                Scales = new ChartScales
                {
                    XAxes = new List<ChartScale>
                    {
                        new ChartScale
                        {
                            Ticks = new ChartTicks
                            {

                            },
                        },
                    },
                    YAxes = new List<ChartScale>
                    {
                        new ChartScale
                        {
                            Ticks = new ChartTicks
                            {

                            },
                        },
                    },
                },
            },
        };
        await JSRuntime.InvokeVoidAsync("setupChart", Id, chartConfig);
    }
}
