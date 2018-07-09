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
    private List<int> streetsInRoute;
    private bool pathFound = false;
    private bool navIsfinish = true;

  
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
        if(typeOfVehicle is General)
        Car = Resources.Load("Car", typeof(GameObject)) as GameObject;

        if (typeOfVehicle is Ambulance)
        Car = Resources.Load("Ambulance", typeof(GameObject)) as GameObject;

        if (typeOfVehicle is FireTruck)
        Car = Resources.Load("Car", typeof(GameObject)) as GameObject;

        if (typeOfVehicle is Police)
        Car = Resources.Load("Police", typeof(GameObject)) as GameObject;

        Car.transform.position = new Vector2(pointInitVehicle.X, pointInitVehicle.Y);
        Instantiate(Car);
        this.pointInitVehicle = pointInitVehicle;
        this.typeOfVehicle = typeOfVehicle;
    }

    public void setTargets(Route route)
    {
        for(int i = 0; i<route.Streets.Count; i++)
        {
            target[i].position = new Vector2(route.Streets[i].GetEndPoint().X, route.Streets[i].GetEndPoint().Y);
        }
    }
    public void movement() {
        this.NavIsfinish = true;
        //to do

    }

    public void findPath(int currentStreet,int destStreet) {
        if (!pathFound)
        {
            if (MapClass.CostMetrics[currentStreet][destStreet] != 0)
            {
                streetsInRoute.Add(destStreet);
                pathFound = true;
                return;
            }
            for (int i = 0; i < MapClass.Streets.Length; i++)
            {
                if (MapClass.CostMetrics[currentStreet][i] != 0)
                {
                    if (streetsInRoute.Contains(i))
                    {
                        continue;
                    }
                    streetsInRoute.Add(i);
                    findPath(i, destStreet);
                }
            }
            streetsInRoute.Remove(currentStreet);
            return;
        }
        else return;
    }
        
    public Route navigation(Point initialPoint, Point destPoint) {
        Car.transform.position = new Vector2(initialPoint.X, initialPoint.Y);
        int currentStreet = 0;
        int destStreet = 0;
        for(int i = 0; i < MapClass.Streets.Length; i++)
        {
            if (Mathf.Abs(Car.transform.position.x  - MapClass.Streets[i].GetStartPoint().X)< 34 && Mathf.Abs(Car.transform.position.x - MapClass.Streets[i].GetStartPoint().X) < 34)
            {
                currentStreet = i;
                break;
            }
        }
        
        for(int i = 0;i< MapClass.Streets.Length; i++)
        {
            if (destPoint == MapClass.Streets[i].GetStartPoint())
            {
                destStreet = i;
                break;
            }
        }
        this.streetsInRoute.Clear();
        this.streetsInRoute.Add(currentStreet);
        findPath(currentStreet, destStreet);
        this.pathFound = false;
        this.route.Streets.Clear();
        for(int i = 0; i<streetsInRoute.Count; i++)
        {
            this.route.Streets.Add(MapClass.Streets[streetsInRoute[i]]);
        }
        return route; }
    private void trafficComponentCheck() { //to do
    }

    
    
    
    
    //...................setters and getters.....................//
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

    public GameObject Car
    {
        get
        {
            return car;
        }

        set
        {
            car = value;
        }
    }

    public bool NavIsfinish
    {
        get
        {
            return navIsfinish;
        }

        set
        {
            navIsfinish = value;
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
