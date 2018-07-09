using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTruck : Type {


    public override int search()
    {


        int fireStreet = 0;
        for (int i = 0; i < MapClass.Buildings.Length; i++)
        {
            if (MapClass.Buildings[i] is FireStation)
            {
                
                for(int j = 0; j<MapClass.Streets.Length; j++)
                {
                    if (MapClass.Map[MapClass.Buildings[i].GetTopRightCorner().Y][MapClass.Buildings[i].GetTopRightCorner().X+1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetTopRightCorner().Y][MapClass.Buildings[i].GetTopRightCorner().X -1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetTopRightCorner().Y+1][MapClass.Buildings[i].GetTopRightCorner().X ] == 100 + MapClass.Streets[i].StreetNumber||
                        MapClass.Map[MapClass.Buildings[i].GetTopRightCorner().Y-1][MapClass.Buildings[i].GetTopRightCorner().X ] == 100 + MapClass.Streets[i].StreetNumber||
                        
                        MapClass.Map[MapClass.Buildings[i].GetTopLeftCorner().Y][MapClass.Buildings[i].GetTopLeftCorner().X + 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetTopLeftCorner().Y][MapClass.Buildings[i].GetTopLeftCorner().X - 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetTopLeftCorner().Y + 1][MapClass.Buildings[i].GetTopLeftCorner().X] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetTopLeftCorner().Y - 1][MapClass.Buildings[i].GetTopLeftCorner().X] == 100 + MapClass.Streets[i].StreetNumber ||

                        MapClass.Map[MapClass.Buildings[i].GetBottomRightCorner().Y][MapClass.Buildings[i].GetBottomRightCorner().X + 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomRightCorner().Y][MapClass.Buildings[i].GetBottomRightCorner().X - 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomRightCorner().Y + 1][MapClass.Buildings[i].GetBottomRightCorner().X] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomRightCorner().Y - 1][MapClass.Buildings[i].GetBottomRightCorner().X] == 100 + MapClass.Streets[i].StreetNumber ||

                         MapClass.Map[MapClass.Buildings[i].GetBottomLeftCorner().Y][MapClass.Buildings[i].GetBottomLeftCorner().X + 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomLeftCorner().Y][MapClass.Buildings[i].GetBottomLeftCorner().X - 1] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomLeftCorner().Y + 1][MapClass.Buildings[i].GetBottomLeftCorner().X] == 100 + MapClass.Streets[i].StreetNumber ||
                        MapClass.Map[MapClass.Buildings[i].GetBottomLeftCorner().Y - 1][MapClass.Buildings[i].GetBottomLeftCorner().X] == 100 + MapClass.Streets[i].StreetNumber
                        )
                    {
                        fireStreet = MapClass.Streets[i].StreetNumber;
                    }
                    
                }
            }

        }
        return fireStreet;
        throw new NotImplementedException();
    }
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
