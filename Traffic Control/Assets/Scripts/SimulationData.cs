[System.Serializable]
public class SimulationData
{
    private int length;
    private int width;
    private int streetNumber;
    private int buildingNumber;
    private Street[] streets;
    private Building[] buildings;
    private int[][] map;
    private Settings settings;
    private int[][] costMetrics;

    public int Length
    {
        get
        {
            return length;
        }

        set
        {
            length = value;
        }
    }

    public int Width
    {
        get
        {
            return width;
        }

        set
        {
            width = value;
        }
    }

    public int StreetNumber
    {
        get
        {
            return streetNumber;
        }

        set
        {
            streetNumber = value;
        }
    }

    public int BuildingNumber
    {
        get
        {
            return buildingNumber;
        }

        set
        {
            buildingNumber = value;
        }
    }

    public Street[] Streets
    {
        get
        {
            return streets;
        }

        set
        {
            streets = value;
        }
    }

    public Building[] Buildings
    {
        get
        {
            return buildings;
        }

        set
        {
            buildings = value;
        }
    }

    public int[][] Map
    {
        get
        {
            return map;
        }

        set
        {
            map = value;
        }
    }

    public Settings Settings
    {
        get
        {
            return settings;
        }

        set
        {
            settings = value;
        }
    }

    public int[][] CostMetrics
    {
        get
        {
            return costMetrics;
        }

        set
        {
            costMetrics = value;
        }
    }

    public SimulationData(int length, int width, int streetNumber, int buildingNumber, Street[] streets, Building[] buildings, int[][] map, Settings settings, int[][] costMetrics)
    {
        this.Length = length;
        this.Width = width;
        this.StreetNumber = streetNumber;
        this.BuildingNumber = buildingNumber;
        this.Streets = streets;
        this.Buildings = buildings;
        this.Map = map;
        this.Settings = settings;
        this.costMetrics = costMetrics;
    }
}
