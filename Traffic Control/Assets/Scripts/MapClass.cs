using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]


public class MapClass
{

    private int length;
    private int width;
    private int streetNumber;
    private int buildingNumber;
    private Street[] streets;
    private Building[] buildings;
    private int[][] map;
    private Save save;
    private Settings settings;



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

    public void setCarNumber(float cn)
    {

        settings.CarNumber = (int)cn;
    }




    //SAVE & LOAD
    public void saveData()
    {
        save = new Save
        {
            currentBuildingNumber = buildingNumber,
            currentBuildings = Buildings,
            currentLength = length,
            currentMap = map,
            currentWidth = width,
            currentStreets = streets,
            currentStreetNumber = streetNumber
        };
        save.SaveFile();
    }

    public void LoadFile()
    {
        save.LoadFile();
        buildingNumber = save.currentBuildingNumber;
        Buildings = save.currentBuildings;
        length = save.currentLength;
        map = save.currentMap;
        width = save.currentWidth;
        streets = save.currentStreets;
        buildingNumber = save.currentStreetNumber;

    }



















    //Must be filled later!
    public MapClass()
    {
        settings = new Settings();
        Streets = new Street[20];
        Buildings = new Building[20];
        Map = new int[length][];
    }

    public void AddStreet(Point start, Point end)
    {
        int i;
        for (i = 0; Streets[i] != null; i++) ;
        Streets[i] = new Street(start, end);
        if (start.Y == end.Y)
        {
            if (start.X < end.X)
            {
                for (int j = 0; j <= System.Math.Abs(start.X - end.X); j++)
                {
                    Map[start.Y][start.X + j] = Streets[i].StreetNumber + 100;
                }
            }
            else
            {
                for (int j = 0; j <= System.Math.Abs(start.X - end.X); j++)
                {
                    Map[end.Y][end.X + j] = Streets[i].StreetNumber + 100;
                }
            }
        }
        else
        {

            if (start.Y < end.Y)
            {
                for (int j = 0; j <= System.Math.Abs(start.Y - end.Y); j++)
                {
                    Map[start.Y + j][start.X] = Streets[i].StreetNumber + 100;
                }
            }
            else {
                for (int j = 0; j <= System.Math.Abs(start.Y - end.Y); j++)
                {
                    Map[end.Y + j][end.X] = Streets[i].StreetNumber + 100;
                }

            }
        }

    }

    public void AddBuilding(Point topLeft, Point topRight, Point bottomRight, Point bottomLeft)
    {
        int i;
        for (i = 0; Buildings[i] != null; i++) ;
        Buildings[i] = new Building(topLeft, topRight, bottomRight, bottomLeft);
        for (int j = 0; j <= System.Math.Abs(topLeft.Y - topRight.Y); j++)
        {
            for (int k = 0; k <= System.Math.Abs(topLeft.X - bottomRight.X); k++)
            {
                Map[topLeft.Y + j][topLeft.X + k] = 200 + Buildings[i].BuildingNumber;
            }
        }

    }


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
