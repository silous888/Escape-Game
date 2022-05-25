using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class enigme_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool resolu;
    public GameObject porte_placard;

    public GameObject player;
    public GameObject cam_pc;
    public GameObject cam_player;
    public GameObject interfaceEnigme;
    public TMP_InputField reponse;



    // Update is called once per frame
    void Update()
    {
        //alt+155 = ø
        if(reponse.text=="x@P3røCUBE666"){
            resolu=true;
            gameObject.GetComponent<utilisation_pc2>().resolu=true;
            porte_placard.GetComponent<Animation>().Play();
            cam_player.GetComponent<voice_gestion>().vaisseau_play();
            interfaceEnigme.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            cam_pc.gameObject.SetActive(false);
            player.gameObject.SetActive(true);
            curseur.SetActive(true);
            cam_player.gameObject.GetComponent<cam_focus_pc>().enabled = false;
            gameObject.GetComponent<enigme_2>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("defocus");
            interfaceEnigme.SetActive(false);
            cam_pc.gameObject.SetActive(false);
            player.gameObject.SetActive(true);
            cam_player.gameObject.GetComponent<cam_focus_pc>().enabled = false;
            Cursor.lockState = CursorLockMode.Locked;

        }

    }
}
