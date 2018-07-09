﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCar : MonoBehaviour {

    private GameObject car;
    public Transform panel;
	// Use this for initialization
	public void Create () {
        //GameObject instance = Instantiate(Resources.Load("Car", typeof(GameObject))) as GameObject;
        car = Resources.Load("Car", typeof(GameObject)) as GameObject;
        car.transform.position = new Vector2(0, 0);
        Instantiate(car);
	}
	
	 //Update is called once per frame
	void Update () {
        car.transform.position = new Vector2(car.transform.position.x, car.transform.position.y + 1);
        if (car.transform.position.x > panel.position.x + 10)
            Destroy(car);
	}
}
