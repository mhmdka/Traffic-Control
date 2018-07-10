using UnityEngine;
using System.Collections;

public abstract class Event : MonoBehaviour
{

    protected Point point;

    public Point Point
    {
        get
        {
            return point;
        }

        set
        {
            point = value;
        }
    }
}   
    //// Use this for initialization
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

