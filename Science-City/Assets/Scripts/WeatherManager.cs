using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    public enum TypesOfDays {Sunny, Shade, Storms };
    public TypesOfDays TodaysWeather;

    
    
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
        //Debug.Log("Change Weather");
        int randomize = Random.Range(0, 50);
            switch (TodaysWeather)
            {
                case TypesOfDays.Shade:
                if(randomize <= 30)
                {
                    TodaysWeather = TypesOfDays.Storms;
                }
                else
                {
                    TodaysWeather = TypesOfDays.Sunny;
                }
                    break;
                case TypesOfDays.Storms:
                if(randomize <= 25)
                {
                    TodaysWeather = TypesOfDays.Storms;
                }
                else
                {
                    TodaysWeather = TypesOfDays.Shade;
                }
                    break;
                case TypesOfDays.Sunny:
                if(randomize <= 28)
                {
                    TodaysWeather = TypesOfDays.Sunny;
                }
                else
                {
                    TodaysWeather = TypesOfDays.Shade;
                }
                    break;
            }
    }
    
}
