using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change {

    private int changeType;
    private Point location;

    public int ChangeType
    {
        get
        {
            return changeType;
        }

        set
        {
            changeType = value;
        }
    }

    public Point Location
    {
        get
        {
            return location;
        }

        set
        {
            location = value;
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
