using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerData : MonoBehaviour
{
    public char Direction = ' ';
    public float PreviousLayer = 0;
    public float CurrentLayer = 0;
    public int DirectionChange = 0;
    public char DirectionPrev = ' ';

    // Start is called before the first frame update
    void Start()
    {
        CurrentLayer = Mathf.Round(Input.gyro.userAcceleration.z * 100f)/100f;
    }

    // Update is called once per frame
    void Update()
    {
        //Prints the acceleration values to the console
        //z axis determines the direction of the phone from the back plate. -ve means away from the user

        char DirectionNew = ' ';

        PreviousLayer = CurrentLayer; //Assigns the old layer to the previous layer variable

        CurrentLayer = Mathf.Round(Input.gyro.userAcceleration.z * 10f)/10f; //Assigns the current accleration to the CurrentLayer variable


        if (PreviousLayer < 0 && CurrentLayer < 0)
        {
            DirectionNew = 'O'; //Define the direction for being outwards
        }
        else if (PreviousLayer > 0 && CurrentLayer > 0)
        {
            DirectionNew = 'I'; //Define the direction for being inwards 
        }

        if (DirectionNew != Direction)
        {
            if (DirectionNew == 'I')
            {
                GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                GameObject.Find("Cube").GetComponent<Renderer>().material.color = Color.gray;
            }

            Debug.Log("Current Layer: " + CurrentLayer + " Direction: " + DirectionNew); //Prints the data out to the screen
        }
        Direction = DirectionNew;
        

        //Debug.Log("X: " + Mathf.Round(Input.gyro.userAcceleration.x * 100f) / 100f + "Y: " + Mathf.Round(Input.gyro.userAcceleration.y * 100f) / 100f + "Z: " + Mathf.Round(Input.gyro.userAcceleration.z * 100f) / 100f);

        
    }
}
