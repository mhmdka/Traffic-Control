using UnityEngine;
using System.Collections;

public class Fire : Event
{
    private int radius = 1;
    private int intensity;




    public Fire(Point point, int radius, int intensity)
    {
        this.point = point;
        this.Radius = radius;
        this.Intensity = intensity;
    }

    public int Radius
    {
        get
        {
            return radius;
        }

        set
        {
            radius = value;
        }
    }

    public int Intensity
    {
        get
        {
            return intensity;
        }

        set
        {
            intensity = value;
        }
    }
}
