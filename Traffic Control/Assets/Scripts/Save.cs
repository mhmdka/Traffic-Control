using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class Save
{
     public int currentLength=2;
     public int currentWidth =3;
     public int currentStreetNumber =3;
     public int currentBuildingNumber=4;
     public Street[] currentStreets;
     public Building[] currentBuildings;
     public int[][] currentMap;
     public Settings currentSettings;
     public int[][] currentCostMetrics;




    void Start()
    {
        SaveFile();
        LoadFile();
    }

    public void SaveFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        SimulationData data = new SimulationData(currentLength, currentWidth, currentStreetNumber, currentBuildingNumber, currentStreets, currentBuildings, currentMap, currentSettings, currentCostMetrics);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, data);
        file.Close();
    }

    public void LoadFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return;
        }

        BinaryFormatter bf = new BinaryFormatter();
        SimulationData data = (SimulationData)bf.Deserialize(file);
        file.Close();

        currentLength = data.Length;
        currentWidth = data.Width;
        currentStreetNumber = data.StreetNumber;
        currentBuildingNumber = data.BuildingNumber;
        currentStreets = data.Streets;
        currentBuildings = data.Buildings;
        currentMap = data.Map;
        currentSettings = data.Settings;
        currentCostMetrics = data.CostMetrics;

        Debug.Log(data.Length);
        Debug.Log(data.Width);
        Debug.Log(data.StreetNumber);
        Debug.Log(data.BuildingNumber);
        Debug.Log(data.Streets);
        Debug.Log(data.Buildings);
        Debug.Log(data.Map);
        Debug.Log(data.Settings);
        Debug.Log(data.CostMetrics);
    }


}