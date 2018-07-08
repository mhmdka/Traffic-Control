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

        SimulationData data = new SimulationData(currentLength, currentWidth, currentStreetNumber, currentBuildingNumber, currentStreets, currentBuildings, currentMap, currentSettings);
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

        currentLength = data.length;
        currentWidth = data.width;
        currentStreetNumber = data.streetNumber;
        currentBuildingNumber = data.buildingNumber;
        currentStreets = data.streets;
        currentBuildings = data.buildings;
        currentMap = data.map;
        currentSettings = data.settings;

        Debug.Log(data.length);
        Debug.Log(data.width);
        Debug.Log(data.streetNumber);
        Debug.Log(data.buildingNumber);
        Debug.Log(data.streets);
        Debug.Log(data.buildings);
        Debug.Log(data.map);
        Debug.Log(data.settings);
    }


}