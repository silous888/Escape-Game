using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_doors : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public int doors_type;
    Vector3 vec;
    float pos;
    bool open;
    // Start is called before the first frame update
    private void Start()
    {
        if (doors_type == 1)
        {
            vec = Vector3.left;
            pos = left.transform.position[0];
        }
        if (doors_type == 2)
        {
            vec = Vector3.down;
            pos = left.transform.position[2];
        }
        if (doors_type == 3)
        {
            vec = Vector3.up;
            pos = left.transform.position[2];
        }
        
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        open = left.GetComponent<info_ouverture>().ouvert;

        if ((doors_type == 1) && (Mathf.Abs(left.transform.position[0] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[0];
        }
        if ((doors_type == 2) && (Mathf.Abs(left.transform.position[2] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[2];
        }
        if ((doors_type == 3) && (Mathf.Abs(left.transform.position[2] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[2];
        }


        if (!open)
        {
            //print("ouverture");
            left.transform.Translate(vec *2.0f* Time.deltaTime, Space.Self);
            right.transform.Translate(-vec * 2.0f*Time.deltaTime, Space.Self);
        }
        else
        {
            //print("fermeture");
            left.transform.Translate(-vec *2.0f* Time.deltaTime, Space.Self);
            right.transform.Translate(vec *2.0f* Time.deltaTime, Space.Self);
        }
    
   

    }

}
