using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventaire : MonoBehaviour
{
    // Start is called before the first frame update
    public bool wrench;
    public bool key_red;
    public bool key_green;
    public bool key_blue;
    public Image wrench_im;
    void Start()
    {
        wrench = false;
        key_red=false;
        key_green=false;
        key_blue=false;
}

    // Update is called once per frame
    void Update()
    {
    //    if (wrench)wrench_im.enabled = true;
   //     else wrench_im.enabled = false;

    }
}
