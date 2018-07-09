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
    protected List<Vehicle> vehicles = new List<Vehicle>();
    private System.Random rnd = new System.Random();
    private MapClass mapClass = new MapClass(); //this has to be used in main class in static way



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

    //====================================== Methods ========================================//

    public void createVehicle(Type typeOfVehicle)
    {
        Point tmp_point = new Point(1,2);
        //tmp_point = randomPointGenerator();
        Vehicle tmp_vehicle = new Vehicle(tmp_point, typeOfVehicle);
        vehicles.Add(tmp_vehicle);
    }
	//----------------------------------------
	
	private Point randomPointGenerator()
	{
		
		Point point = new Point();
		int index = rnd.Next(0, mapClass.Streets.Length-1);
		point = mapClass.Streets[index].GetStartPoint();
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

    }
}
