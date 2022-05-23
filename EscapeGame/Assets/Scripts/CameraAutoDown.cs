using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraAuto : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.05f, 0);

        if (Input.GetMouseButtonDown(0))
        {
            transform.Translate(0, -1f, 0);

        }

    }
}
