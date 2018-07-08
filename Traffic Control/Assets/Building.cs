using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]


public class Building : MonoBehaviour {
    private Point topLeftCorner, bottomLeftCorner, topRightCorner, bottomRightCorner;
    private int area;
    private int trafficCoef;
    private readonly int elementType = 2;
    private int buildingNumber;
    private int buildingType;

    public int Area
    {
        get
        {
            return area;
        }
    }

    public int TrafficCoef
    {
        get
        {
            return trafficCoef;
        }

        set
        {
            trafficCoef = value;
        }
    }

    public int ElementType
    {
        get
        {
            return elementType;
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

    public int BuildingType
    {
        get
        {
            return buildingType;
        }

        set
        {
            buildingType = value;
        }
    }

    public void SetBottomLeftCorner(int x, int y)
    {
        this.bottomLeftCorner.X = x;
        this.bottomLeftCorner.Y = y;
        if (bottomLeftCorner != null)
            area = areaCalc();
    }
    public Point GetBottomLeftCorner()
    {
        return bottomLeftCorner;
    }
    public void SetTopLeftCorner(int x, int y)
    {
        this.topLeftCorner.X = x;
        this.topLeftCorner.Y = y;
        if (topLeftCorner != null)
            area = areaCalc();
    }
    public Point GetTopLeftCorner()
    {
        return topLeftCorner;
    }
    public void SetTopRightCorner(int x, int y)
    {
        this.topRightCorner.X = x;
        this.topRightCorner.Y = y;
        if (topRightCorner != null)
            area = areaCalc();
    }
    public Point GetTopRightCorner()
    {
        return topRightCorner;
    }
    public void SetBottomRightCorner(int x, int y)
    {
        this.bottomRightCorner.X = x;
        this.bottomRightCorner.Y = y;
        if (bottomRightCorner != null)
            area = areaCalc();
    }
    public Point GetBottomRightCorner()
    {
        return bottomRightCorner;
    }

    public int areaCalc()
    {
        int area;
        area = (System.Math.Abs(topLeftCorner.X - topRightCorner.X)+1) * (System.Math.Abs(topLeftCorner.Y - bottomLeftCorner.Y)+1);
        return area;

    }

    public Building() { }
    // NOT COMPLETE
    public Building(Point topLeft,Point topRight,Point bottomRight,Point bottomLeft)
    {
        topRightCorner = topRight;
        topLeftCorner = topLeft;
        bottomRightCorner = bottomRight;
        bottomLeftCorner = bottomLeft;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
