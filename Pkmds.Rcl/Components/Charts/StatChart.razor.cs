namespace Pkmds.Rcl.Components.Charts;

public partial class StatChart
{
    [Parameter, EditorRequired]
    public PKM Pokemon { get; set; } = default!;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        var stats = Pokemon.GetStats(Pokemon.PersonalInfo);
        Data = new List<double>
        {
            stats[(int)Stats.Hp],
            stats[(int)Stats.Attack],
            stats[(int)Stats.Defense],
            stats[(int)Stats.Speed],
            stats[(int)Stats.SpecialDefense],
            stats[(int)Stats.SpecialAttack],
        };
    }

    private enum Stats
    {
        Hp,
        Attack,
        Defense,
        Speed,
        SpecialAttack,
        SpecialDefense,
    }

    private List<double> Data { get; set; } = new List<double>();

    private static string[] Labels => new[]
    {
        "HP",
        "Attack",
        "Defense",
        "Speed",
        "Special Defense",
        "Special Attack",
    };

    private static string[] BackgroundColor => new[]
    {
        "#A6A6A688"
         // "Red", "Orange", "Yellow", "Blue", "Green", "Pink",
    };
}
