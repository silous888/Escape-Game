using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme_2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool resolu;
    public GameObject porte_placard;

    public GameObject player;
    public GameObject cam_pc;
    public GameObject cam_player;
    public GameObject interfaceEnigme;

    private void Start()
    {
        interfaceEnigme.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (resolu) porte_placard.GetComponent<Animation>().enabled = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {

            print("defocus");
            interfaceEnigme.SetActive(false);
            cam_pc.gameObject.SetActive(false);
            player.gameObject.SetActive(true);
            cam_player.gameObject.GetComponent<cam_focus_pc>().enabled = false;

        }

    }
}
