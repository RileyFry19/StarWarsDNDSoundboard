namespace SoundBoard.Components;
public class Enums
{
    public enum Queries
    {
        SpaceCombat,
        Combat,
        LightsaberDuel,
        Cues,
        Exploration,
        Sad,
        Sneaky,
        Peaceful,
        LightSide,
        DarkSide,
        TheEmpire,
        Confrontation,
        ChaseAction,
        Cantina,
        TenseSpooky,
        Misc
    }
    
    public static string FormatDirectories(string value)
    {
        return string.Concat(value.Select((x, i) => i > 0 && char.IsUpper(x) ? " " + x : x.ToString()));
    }
}