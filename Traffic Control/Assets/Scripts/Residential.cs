using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Residential : Building {

    public Residential(Point topLeft, Point topRight, Point bottomRight, Point bottomLeft) : base(topLeft, topRight, bottomRight, bottomLeft)
    {
        trafficCoef = 1;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
