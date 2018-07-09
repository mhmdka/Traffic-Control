using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ManageVehicles : MonoBehaviour
{
    //==================================== properties ======================================//

    private readonly int MAP_WIDTH,MAP_LENGTH;
    public int NUMBER_OF_VEHICLES=4;

    protected bool isElementChanged = false;
    protected bool isEventOccured = false;
    protected bool isTrafficChanged = false;
    private Event evenObject;
    protected List<Vehicle> vehicles = new List<Vehicle>();
    private System.Random rnd = new System.Random();
    


    //----------- set/get ------------//

    public bool IsElementChanged
    {
        set { isElementChanged = value; }
        get { return isElementChanged; }
    }

    public bool IsEventOccured
    {
        set { isEventOccured = value; }
        get { return isEventOccured; }
    }

    public bool IsTrafficChanged
    {
        set { isTrafficChanged = value; }
        get { return isTrafficChanged; }
    }

    public List<Vehicle> Vehicles
    {
        set;
        get;
    }

    public Event EvenObject
    {
        get
        {
            return evenObject;
        }

        set
        {
            evenObject = value;
        }
    }

    //====================================== Methods ========================================//

    

    public void createVehicle(Type typeOfVehicle)
    {
        Point tmp_point;
        tmp_point = randomPointGenerator();
        Vehicle tmp_vehicle = new Vehicle(tmp_point, typeOfVehicle);
        vehicles.Add(tmp_vehicle);
    }
	//----------------------------------------
	
	private Point randomPointGenerator()
	{
		
		Point point = new Point();
		int index = rnd.Next(0, MapClass.Streets.Length-1);
		point = MapClass.Streets[index].GetStartPoint();
		return point;
		
	}
    //---------------------------------------

    //public void manageMovement(Events events)
    //{

    //}


    //-----------------------------------------




    // Use this for initializations
    void Start()
    {
        General gn = new General();
        for (int i = 0; i < NUMBER_OF_VEHICLES; i++){
            createVehicle(gn);
        }


    }

    // Update is called once per frame
    void Update()
    {  
            Point destPoint;
            for (int i = 0; i < Vehicles.Count; i++)
            {
                if (Vehicles[i].NavIsfinish)
                {
                    Vehicles[i].NavIsfinish = false;
                    destPoint = randomPointGenerator();
                    if (Vehicles[i].Car.transform.position.x == destPoint.X && Vehicles[i].Car.transform.position.y == destPoint.Y)
                    {
                        Vehicles[i].NavIsfinish = true;
                        continue;
                    }

                    Vehicles[i].navigation(new Point((int)Vehicles[i].Car.transform.position.x, (int)Vehicles[i].Car.transform.position.y)
                        , destPoint);
                    Vehicles[i].movement();
                }
            }

        if (isEventOccured || isTrafficChanged) {
            
            // when accident happens 
            if (isEventOccured)
            {
                if(EvenObject is Rain)
                {

                }
                if (EvenObject is Fire) {
                    int ambulanceStreet;
                    Ambulance amb = new Ambulance();
                    ambulanceStreet = amb.search();
                    Vehicle ambulance = new Vehicle(MapClass.Streets[ambulanceStreet].GetStartPoint(), amb);
                    ambulance.navigation(MapClass.Streets[ambulanceStreet].GetStartPoint(), this.EvenObject.Point); //sina will add
                    ambulance.movement();
                }
                
                isEventOccured = false  ;
            }

            //when traffic is changed
            if (isTrafficChanged)
            {
                isTrafficChanged = false;
            }
        }
    }
}
