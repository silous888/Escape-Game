using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
public class object_use : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public GameObject text;
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if(hit.transform.gameObject == gameObject)
            {
                if (hit.distance < 5)
                {

                    gameObject.GetComponent<Outline>().enabled = true;
                
                    text.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        print("space key was pressed");
                        gameObject.GetComponent<big_doors>().enabled = true;
                        
                    }
                }
            }
            else
            {
                gameObject.GetComponent<Outline>().enabled = false;
                text.SetActive(false);
            }
        }
    }
}
