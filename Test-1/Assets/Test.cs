using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour {
    public GameObject g;
    public Button b;
    
	// Use this for initialization
	void Start () {
        g.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        //b.onClick.AddListener(OnButton());
    }
    public void OnButton(GameObject g)
    {
        g.SetActive(false);
    }

}
