using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Street : MonoBehaviour {

    private int length;
    private Point startPoint;
    private Point endPoint;
    private int trafficCoef;
    private int maxCoef;
    private readonly int elementType=1;
    private bool endToStart;
    private bool startToEnd;
    private int streetNumber;

    public int Length
    {
        get
        {
            return length;
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

    public int MaxCoef
    {
        get
        {
            return maxCoef;
        }

        set
        {
            maxCoef = value;
        }
    }

    public int ElementType
    {
        get
        {
            return elementType;
        }
    }

    public void SetStartPoint(int x,int y)
    {
        this.startPoint.X = x;
        this.startPoint.Y = y;
        if(startPoint!=null)
            length = DistanceCalc();
    }
    public Point GetStartPoint()
    {
        return startPoint;
    }

    public void SetEndPoint(int x, int y)
    {
        this.endPoint.X = x;
        this.endPoint.Y = y;
        if(endPoint!=null)
            length = DistanceCalc();
    }
    public Point GetEndPoint()
    {
        return endPoint;
    }

    public int DistanceCalc()
    {
        int distance=0;
        if (endPoint.X - startPoint.X == 0) {
            distance = endPoint.Y - startPoint.Y+1;
            return System.Math.Abs(distance);
        }
        distance = endPoint.X - startPoint.X+1;
        return System.Math.Abs(distance);
    }

    public bool StartToEnd
    {
        get
        {
            return startToEnd;
        }

        set
        {
            startToEnd = value;
        }
    }

    public bool EndToStart
    {
        get
        {
            return endToStart;
        }

        set
        {
            endToStart = value;
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

    public Street() { }

    // NOT COMPLETE

    public Street(Point start, Point end) {
        startPoint = start;
        endPoint = end;
    }




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
