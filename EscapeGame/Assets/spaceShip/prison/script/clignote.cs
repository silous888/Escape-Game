using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clignote : MonoBehaviour
{
    // Start is called before the first frame update
    public float periode;
    bool toggle = false;
    float time_left;


    // Update is called once per frame
    void Update()
    {
        time_left += Time.deltaTime;
        if (time_left > periode)
        {
            if (toggle) GetComponent<Light>().intensity = 0.0f;
            else GetComponent<Light>().intensity = 30.0f;
            time_left = 0f;
            toggle = !toggle;
        }

         
    }
}
