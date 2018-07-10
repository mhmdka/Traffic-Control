using UnityEngine;
using System.Collections;

public class Accident : Event
{
    private int intensity;
    private int numberOfCars = 2;
   
    public Accident(Point point, int intensity, int numberOfCars)
    {
        this.point = point;
        this.intensity = intensity;
        this.numberOfCars = numberOfCars;
    }

    public int NumberOfCars
    {
        get
        {
            return numberOfCars;
        }

        set
        {
            numberOfCars = value;
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
