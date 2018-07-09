using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Route : MonoBehaviour {

    private Point initPoint, destPoint;
    private Street[] streets;

    public Point InitPoint { get { return initPoint; } set { initPoint = value; } }
    public Point DestPoint { get { return destPoint; } set { destPoint = value; } }
    public Street[] Streets { get { return streets; } set { streets = value; } }
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
