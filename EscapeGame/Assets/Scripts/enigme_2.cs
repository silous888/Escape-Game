using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool resolu;
    public GameObject porte_placard;

    // Update is called once per frame
    void Update()
    {
        if (resolu) porte_placard.GetComponent<Animation>().enabled = true;
    }
}
