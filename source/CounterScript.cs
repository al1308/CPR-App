using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScript : MonoBehaviour
{
    public float timeCount = 0.0f;
    public int TimeShown = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //fixed time 0.02
        timeCount += 0.02f;

        if (timeCount >= 0.5)
        {
            IncrementCount();
            GetComponent<TextMesh>().text = TimeShown.ToString();
            timeCount = 0;
        }


    }

    private void IncrementCount()
    {
        if (TimeShown + 1 > 4)
        {
            TimeShown = 1;
        }
        else
        {
            TimeShown += 1;
        }
    }

}
