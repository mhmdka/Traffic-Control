using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBump : TrafficElement {

    private int streetSpeedChange;


    public SpeedBump()
    {
        this.streetSpeedChange = 10;
    }

    public int StreetSpeedChange
    {
        get
        {
            return streetSpeedChange;
        }

        set
        {
            streetSpeedChange = value;
        }
    }
}
