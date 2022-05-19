using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tranlation_du_demon : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.forward*speed * Time.deltaTime, Space.Self);
    }
}
