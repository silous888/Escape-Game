using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
public class utilisation_pc2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public Text text;
    public bool resolu;
    public GameObject cam_pc;
    public GameObject interfaceEnigme;


    private void Start()
    {
        resolu = false;
    }
    // Update is called once per frame
    void Update()
    {
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
                    gameObject.GetComponent<enigme_2>().enabled = false;
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    interfaceEnigme.SetActive(true);
                    Cursor.lockState = CursorLockMode.Confined;
                    print("e key was pressed");
                    cam.GetComponent<cam_focus_pc>().cam_pc = cam_pc;
                    cam.GetComponent<cam_focus_pc>().num_enigme = 2;
                    cam.GetComponent<cam_focus_pc>().y = 1;
                    cam.GetComponent<cam_focus_pc>().x = -1;
                    cam.GetComponent<cam_focus_pc>().z = 0;
                    cam.GetComponent<cam_focus_pc>().pc = gameObject;
                    gameObject.GetComponent<enigme_2>().enabled = true;
                    if (!resolu) cam.GetComponent<cam_focus_pc>().enabled = true;
                    


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
