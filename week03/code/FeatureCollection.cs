using System.Collections.Generic;

public class FeatureCollection
{
    public List<Feature> Features { get; set; } = new();
    
}
public class Feature
{
    public Properties properties { get; set; } = new();
}
public class Properties
{
    public string place {get; set; } = "";
    public double mag {get; set; }
}