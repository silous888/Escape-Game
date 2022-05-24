using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
public class utilisation_pc : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public GameObject cam_pc;
    public Text text;
    public bool resolu;
    public GameObject curseur;
    public bool play_papa;
    private void Start()
    {
        resolu = false;
        play_papa = true;
    }
    // Update is called once per frame
    void Update()
    {
        if ((play_papa)&&(resolu))
        {
            print("play papa");
            play_papa = false;
            cam.GetComponent<voice_gestion>().papa_play();
        }

        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 5))
        {
            if (hit.transform.gameObject == gameObject)
            {

                if (cam.GetComponent<cam_focus_pc>().enabled)
                {
                    text.enabled = false;
                    gameObject.GetComponent<Outline>().enabled = false;
                }
                else
                {
                    text.enabled = true;
                    gameObject.GetComponent<Outline>().enabled = true;
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("e key was pressed");
                    curseur.SetActive(false);
                    cam.GetComponent<cam_focus_pc>().pc = gameObject;
                    cam.GetComponent<cam_focus_pc>().cam_pc = cam_pc;
                    cam.GetComponent<cam_focus_pc>().num_enigme = 1;
                    cam.GetComponent<cam_focus_pc>().y = 1;
                    cam.GetComponent<cam_focus_pc>().x = 0;
                    cam.GetComponent<cam_focus_pc>().z = 1; ;
                    if (!resolu) cam.GetComponent<cam_focus_pc>().enabled = true;
                    else
                    {
                    gameObject.GetComponent<big_doors>().enabled = true;
                    curseur.SetActive(true);
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
