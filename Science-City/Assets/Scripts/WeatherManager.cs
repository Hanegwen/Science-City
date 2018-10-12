using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    enum TypesOfDays {Sunny, Shade, Storms };
    TypesOfDays TodaysWeather;

    int DaysInARow = 0;
    
	// Use this for initialization
	void Start ()
    {
        TodaysWeather = TypesOfDays.Sunny;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void ChangeWeather()
    {
        Debug.Log("Weather SYSTEM NOT DONE");
        if (DaysInARow > 2)
        {
            switch (TodaysWeather)
            {
                case TypesOfDays.Shade:
                    break;
                case TypesOfDays.Storms:
                    break;
                case TypesOfDays.Sunny:
                    break;
            }
        }

        else if (DaysInARow > 1)
        {
            switch (TodaysWeather)
            {
                case TypesOfDays.Shade:
                    break;
                case TypesOfDays.Storms:
                    break;
                case TypesOfDays.Sunny:
                    break;
            }
        }

        else
        {
            switch (TodaysWeather)
            {
                case TypesOfDays.Shade:
                    break;
                case TypesOfDays.Storms:
                    break;
                case TypesOfDays.Sunny:
                    break;
            }
        }
    }
    
}
