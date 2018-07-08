using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {
    private int carNumber;
    private float simDuration;
    private float simTime;

    public float SimTime
    {
        get
        {
            return simTime;
        }

        set
        {
            simTime = value;
        }
    }

    public float SimDuration
    {
        get
        {
            return simDuration;
        }

        set
        {
            simDuration = value;
        }
    }

    public int CarNumber
    {
        get
        {
            return carNumber;
        }

        set
        {
            carNumber = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
