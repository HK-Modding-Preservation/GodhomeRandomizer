using RandomizerMod.RandomizerData;

public record FixedAreaLocationDef : LocationDef
{
    public string FixedMapArea;
    public string FixedTitledArea;
    public override string MapArea => FixedMapArea;
    public override string TitledArea => FixedTitledArea;
    public FixedAreaLocationDef(string map, string titled)
    {
        FixedMapArea = map;
        FixedTitledArea = titled;
    }
}