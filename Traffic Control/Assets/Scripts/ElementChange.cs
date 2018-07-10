using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ElementChange : MonoBehaviour
{

    public int type;
    public GameObject analysisUnit;
    private int[][] map = MapClass.Map;
    private Settings settings = MapClass.Settings;
    private Change change;
    //private Point clickedPoint = new Point();

    public Change Change
    {
        get
        {
            return change;
        }

        set
        {
            change = value;
        }
    }

    public void ElementPick()
    {
        this.Change = new Change(type);
        //Debug.Log(change.ChangeType);
    }

    public void ChooseMapPoint()
    {
        //Debug.Log(EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().anchoredPosition.x);
        if (this.Change == null)
            Debug.Log("No Change Selected");
        Point topLeft = new Point((-(int)EventSystem.current.currentSelectedGameObject.transform.parent.gameObject.GetComponent<RectTransform>().anchoredPosition.y) / 34, ((int)EventSystem.current.currentSelectedGameObject.GetComponent<RectTransform>().anchoredPosition.x) / 34);
        Point topRight = new Point(topLeft.X + 1, topLeft.Y);
        Point bottomLeft = new Point(topLeft.X, topLeft.Y - 1);
        Point bottomRight = new Point(topLeft.X + 1, topLeft.Y - 1);

        switch (change.ChangeType)
        {
            //case 1:
            //if(possible)
            //start analysis
            //    MapClass.AddTrafficLight();
            //    break;

            //case 2:
            //if(possible)
            //start analysis
            //MapClass.AddSpeedBump();
            //break;

            case 3:
                //if(possible)
                    //start analysis
                MapClass.AddResidentail(topLeft, topRight, bottomRight, bottomLeft);
                break;
            
            //case 4:
                //if(possible)
            //start analysis
                //MapClass.AddBusiness(topLeft, topRight, bottomRight, bottomLeft);
                //break;

            case 5:
                //if(possible)
                //start analysis
                MapClass.AddFireStation(topLeft, topRight, bottomRight, bottomLeft);
                break;

            case 6:
                //if(possible)
                //start analysis
                MapClass.AddPoliceStation(topLeft, topRight, bottomRight, bottomLeft);
                break;

            case 7:
                //if(possible)
                //start analysis
                MapClass.AddHospital(topLeft, topRight, bottomRight, bottomLeft);
                break;
        }

    }
}
