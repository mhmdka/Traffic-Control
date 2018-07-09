using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementChange : MonoBehaviour {

    private int [][] map = MapClass.Map;
    private Settings settings = MapClass.;
    private Change change;
    private Point clickedPoint = new Point();

    public Change Change
    {
        get
        {
            return change;
        }

        set
        {
            change = value;
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
