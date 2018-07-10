using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : TrafficElement {
    private int greenLightDuration;
    private int redLightDuraton;

    public TrafficLight(int greenLightDuration, int redLightDuraton)
    {
        this.GreenLightDuration = greenLightDuration;
        this.RedLightDuraton = redLightDuraton;
        this.streetSpeedChange = 10;
    }

    public int GreenLightDuration
    {
        get
        {
            return greenLightDuration;
        }

        set
        {
            greenLightDuration = value;
        }
    }

    public int RedLightDuraton
    {
        get
        {
            return redLightDuraton;
        }

        set
        {
            redLightDuraton = value;
        }
    }


}
