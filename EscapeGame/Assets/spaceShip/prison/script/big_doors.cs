using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_doors : MonoBehaviour
{
    public GameObject left;
    public GameObject right;

    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if (left.transform.position[0] < -1.5) gameObject.GetComponent<big_doors>().enabled = false;
        
        left.transform.Translate(Vector3.left * Time.deltaTime);
        right.transform.Translate(Vector3.right * Time.deltaTime);
    
    }
}
