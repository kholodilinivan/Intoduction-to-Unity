using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Vehicle 
{
    public float speed;
    public string color;

    public void VehicleSpeed()
    {
        Debug.Log(speed); // print(speed);
    }

    public void VehicleColor()
    {
        Debug.Log(color); // print(color);
    }

    public Vehicle()
    {
        Debug.Log("Vehicle() was called");
    }

    public Vehicle(float speed)
    {
        this.speed = speed;
        Debug.Log(speed);
        Debug.Log("Vehicle(speed) was called");
    }

    public Vehicle(float speed, string colorval)
    {
        this.speed = speed;
        this.color = colorval;
        Debug.Log(speed);
        Debug.Log(color);
        Debug.Log("Vehicle(speed, color) was called");
    }

    public void PrintParams()
    {
        Debug.Log("speed: " + speed);
        Debug.Log("color: " + color);
    }
}
