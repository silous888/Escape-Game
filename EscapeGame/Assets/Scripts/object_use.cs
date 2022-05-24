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
    public Text text;
    bool play_rapport;
    // Update is called once per frame
    private void Start()
    {
        play_rapport = true;
    }
    void Update()
    {
       

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 5))
        {
            if (hit.transform.gameObject == gameObject)
            {

                gameObject.GetComponent<Outline>().enabled = true;

                text.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("e key was pressed");
                    gameObject.GetComponent<big_doors>().enabled = true;
                    if (play_rapport)
                    {
                        print("play rapport");
                        play_rapport = false;
                        cam.GetComponent<voice_gestion>().rapport_play();
                    }
                }

            }
            else
            {
                gameObject.GetComponent<Outline>().enabled = false;
                text.enabled = false;
            }
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
            text.enabled = false;
        }

        
    }
}
