using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public float speed = -0.05f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed, 0);
    }
}
