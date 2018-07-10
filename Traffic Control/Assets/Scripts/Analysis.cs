using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Analysis : MonoBehaviour
{
    public Text analytics;
    private Street[] streetsOnStart;
    private void OnEnable()
    {
        //Debug.Log("activated");
        streetsOnStart = MapClass.Streets;
        //analytics.text = analytics.text + "hey";
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < streetsOnStart.Length; i++)
        {
            if (streetsOnStart[i] != MapClass.Streets[i])
                analytics.text = analytics.text + "changes on  street " + MapClass.Streets[i].StreetNumber + "has Changed."; 
                
        }
    }
}
