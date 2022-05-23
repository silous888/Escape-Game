using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraAuto2 : MonoBehaviour
{
    float speed=0.25f;

       // Update is called once per frame
       void Update()
    {
        transform.Translate(0, -speed, 0);
    }
}
