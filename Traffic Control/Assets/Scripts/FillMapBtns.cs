using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillMapBtns : MonoBehaviour {

    public int RowofArray;
    //private Button[,]
	// Use this for initialization
	void Start () {
        MapClass.mapButtons[RowofArray] = this.GetComponentsInChildren<Button>();
        //MapClass.mapButtons[0][0].gameObject.GetComponent<Image>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
