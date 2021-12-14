using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsWork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vehicle myVehicle = new Vehicle();
        myVehicle.speed = 5.5f;
        myVehicle.color = "Grey";

        Vehicle newVehicle = new Vehicle();
        newVehicle.speed = 10f;
        newVehicle.color = "White";

        myVehicle.VehicleSpeed();
        newVehicle.VehicleSpeed();

        myVehicle.VehicleColor();
        newVehicle.VehicleColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
