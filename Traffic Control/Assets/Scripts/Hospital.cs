using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hospital : Building {
    public Hospital(Point topLeft, Point topRight, Point bottomRight, Point bottomLeft) :base( topLeft,  topRight,  bottomRight,  bottomLeft)
    {
        trafficCoef = 4;

    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
