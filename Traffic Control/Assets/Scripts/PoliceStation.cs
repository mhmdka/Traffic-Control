using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceStation : Building {
    public PoliceStation(Point topLeft, Point topRight, Point bottomRight, Point bottomLeft) : base(topLeft, topRight, bottomRight, bottomLeft)
    {
        trafficCoef = 2;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
