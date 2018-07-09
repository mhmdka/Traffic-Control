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
    private Route route;

    private MapClass mapClass = new MapClass(); //this has to be used in main class in static way

    //.................GUI..............//
    public Transform[] target;
   
   

    private GameObject car;

    //public Vehicle(){
    //    car = Resources.Load("Car", typeof(GameObject)) as GameObject;
    //    car.transform.position = new Vector2(0,0);
    //    //Instantiate(car);
    //}
    public Vehicle (Point pointInitVehicle, Type typeOfVehicle)
    {
        car = Resources.Load("Car", typeof(GameObject)) as GameObject;
        car.transform.position = new Vector2(0, 0);
        Instantiate(car);
        this.pointInitVehicle = pointInitVehicle;
        this.typeOfVehicle = typeOfVehicle;
    }

    public void setTargets(Route route)
    {
        for(int i = 0; i<route.Streets.Length; i++)
        {
            target[i].position = new Vector2(route.Streets[i].GetEndPoint().X, route.Streets[i].GetEndPoint().Y);
        }
    }
    public void movement(Route route) {

    }

    public void setShortestPath() { }
    public Route[] navigation(Point initialPoint, Point destPoint, bool isSpecReq) {
        if (isSpecReq) { }
        this.pointInitVehicle = initialPoint;

        return null; }
    private void trafficComponentCheck() { }

    
    
    
    
    //...................setter and getters.....................//
    public long Score{
        get{ return score;}
        set{ score = value;}
    }

    public Point PointInitVehicle{
        get
        { return pointInitVehicle; }
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

    public Route Route
    {
        get
        {
            return route;
        }

        set
        {
            route = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
