using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Point {

    private int x=0, y=0;

    public int X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public int Y
    {
        get
        {
            return y;
        }

        set
        {
            y = value;
        }
    }

    public Point() { }
    public Point(int x, int y) {
        X = x;
        Y = y;
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
