using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
public class PorteElec : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public Text text;
    public GameObject player;
    private bool etatPorte;

    private void start(){
        etatPorte=false;
    }

    void Update()
    {

        if(!etatPorte){
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 15))
        {
            if (hit.transform.gameObject == gameObject)
            {

                gameObject.GetComponent<Outline>().enabled = true;

                text.enabled = true;
                if (Input.GetKeyDown(KeyCode.E) && player.GetComponent<inventaire>().wrench==true)
                {
                    print("e key was pressed");
                    //Executer ici le script !
                    text.enabled = false;
                    gameObject.GetComponent<Outline>().enabled = false;
                    etatPorte =true;
                    gameObject.GetComponent<Animation>().Play();
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
}
