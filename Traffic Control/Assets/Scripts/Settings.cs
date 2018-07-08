using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]

public class Settings : MonoBehaviour
{

    //public Slider simDurationSlider;
    //public Slider carNumberSlider;
    //public Slider simTimeS

    private int carNumber;
    private float simDuration;
    private float simTime;

    public float SimTime
    {
        get
        {
            return simTime;
        }

        set
        {
            simTime = value;
        }
    }

    public float SimDuration
    {
        get
        {
            return simDuration;
        }

        set
        {
            simDuration = value;
        }
    }

    public int CarNumber
    {
        get
        {
            return carNumber;
        }

        set
        {
            carNumber = value;
        }
    }

    public void OnValueChangeCarNumber(float newValue)
    {
        carNumber = (int)newValue;
        Debug.Log(CarNumber);
    }
    public void OnValueChangeSimDuration(float newValue)
    {
        simDuration = (int)newValue;
        Debug.Log(SimDuration);
    }
    public void OnValueChangeSimTime(float newValue)
    {
        simTime = (int)newValue;
        Debug.Log(SimTime);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
