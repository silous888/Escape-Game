using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class porte_auto : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    bool pres;
    private void Start()
    {
        pres = false;
        time = 0f;
    }
    private void Update()
    {
        if (!pres)
        {
            time += Time.deltaTime;
            if(time>=2.0f) gameObject.GetComponent<big_doors>().enabled = true;
            time = 0.0f;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //check if the collider is tagged as "Player" this time.
        if (other.tag == "Player")
        {
            time = 0.0f;
            pres = true;
            gameObject.GetComponent<big_doors>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            pres = false;
            gameObject.GetComponent<big_doors>().enabled = true;
        }
    }
}
