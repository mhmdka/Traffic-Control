using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ManageVehicles : MonoBehaviour
{
    //public GameObject gameObject;
    //=================== properties ======================//

    protected bool isElementChanged = false;
    protected bool isEventOccured = false;
    protected bool isTrafficChanged = false;
    protected List<Vehicle> vehicles = new List<Vehicle>();

    //------------------ set/get -------------------------//

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
        //------------------ Temp Variables ------------------//
        Point tmp_point;

        //------------------- Program ------------------------//

        tmp_point = randomPointGenerator();
        Vehicle tmp_vehicle = new Vehicle(tmp_point, typeOfVehicle);
        vehicles.Add(tmp_vehicle);

        //----------------------------------------------------//

    }

    //public void manageMovement(Events events)
    //{

    //}
    private Point randomPointGenerator()
    {
        throw new System.Exception();
    }



    // Use this for initializations
    void Start()
    {
        //------------------ Temp Variables ------------------//
        //General general = new General();

        //for (int i = 0; i < NUMBER_OF_VEHICLES;i++){
        //    createVehicle(general);
        //}


    }

    // Update is called once per frame
    void Update()
    {

    }
}
