[System.Serializable]
public class SimulationData
{
    public int length;
    public int width;
    public int streetNumber;
    public int buildingNumber;
    public Street[] streets;
    public Building[] buildings;
    public int[][] map;
    public Settings settings;

    public SimulationData(int length, int width, int streetNumber, int buildingNumber, Street[] streets, Building[] buildings, int[][] map, Settings settings)
    {
        this.length = length;
        this.width = width;
        this.streetNumber = streetNumber;
        this.buildingNumber = buildingNumber;
        this.streets = streets;
        this.buildings = buildings;
        this.map = map;
        this.settings = settings;
    }
}
