using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLight : TrafficElement {
    private bool red, green, specialRouteRequested; 
    private int greenLightDuration;
    private int redLightDuraton;
    private int counter;


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

    public bool Red
    {
        get
        {
            return red;
        }

        set
        {
            red = value;
        }
    }

    public bool Green
    {
        get
        {
            return green;
        }

        set
        {
            green = value;
        }
    }

    public bool SpecialRouteRequested
    {
        get
        {
            return specialRouteRequested;
        }

        set
        {
            specialRouteRequested = value;
        }
    }

    public TrafficLight(int greenLightDuration, int redLightDuraton)
    {
        this.GreenLightDuration = greenLightDuration;
        this.RedLightDuraton = redLightDuraton;
        counter = greenLightDuration;
    }


    void Update()
    {

        if (specialRouteRequested)
        {
            green = true;
            red = false;
        }
        else
        {
            if (green)
            {
                if (counter > 0)
                    counter--;
                else
                {
                    green = false;
                    red = true;
                    counter = RedLightDuraton;
                }
            }

            else if (red)
            {
                if (counter > 0)
                    counter--;
                else
                {
                    red = false;
                    green = true;
                    counter = GreenLightDuration;
                }
            }
                
                
        }
            
        
    }

}
