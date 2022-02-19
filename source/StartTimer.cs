using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTimer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void EnableTimerObject()
    {
        GetComponent<CounterScript>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<AccelerometerData>().enabled = true;
        GameObject.Find("Canvas").SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
