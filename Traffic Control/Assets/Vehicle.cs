using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Vehicle : MonoBehaviour {
    private long score;
    private Point pointInitVehicle;
    private Point pointDest;
    private bool isSpecReq;
    private int velocity;
    private bool isVelocityChanged;
    private bool followSpecReq;
    private Type typeOfVehicle;

    public void movement(Route route) { }
    public Route[] navigation(Point intialPoint, Point destPoint, bool isSpecReq) { }
    private void trafficComponentCheck() { }

    ///////////////////////////setter and getters///////////////////////////
    public long Score{
        get{ return score;}
        set{ score = value;}
    }

    public Point PointInitVehicle{
        get{return pointInitVehicle;}
        set{pointInitVehicle = value;}
    }

    public Point PointDest{
        get{return pointDest;}
        set{pointDest = value;}
    }

    public int Velocity{
        get{return velocity;}
        set{velocity = value;}
    }

    public bool IsVelocityChanged{
        get{return isVelocityChanged;}
        set{isVelocityChanged = value;}
    }

    public bool FollowSpecReq{
        get{return followSpecReq;}
        set{followSpecReq = value;}
    }

    public Type TypeOfVehicle{
        get{return typeOfVehicle;}
        set{typeOfVehicle = value;}
    }
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
