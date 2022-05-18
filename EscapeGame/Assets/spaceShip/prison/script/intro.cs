using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float periode;
    bool toggle = false;
    float time_left;
    float time_start;
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
