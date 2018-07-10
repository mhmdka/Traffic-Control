using UnityEngine;
using System.Collections;

public class Rain : Event
{
    private int rainingTime;

    public Rain(int rainingTime)
    {
        RainingTime = rainingTime;

    }

    public int RainingTime
    {
        get
        {
            return rainingTime;
        }

        set
        {
            rainingTime = value;
        }
    }
}