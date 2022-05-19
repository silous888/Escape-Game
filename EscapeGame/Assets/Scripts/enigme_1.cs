using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigme_1 : MonoBehaviour
{

    public GameObject player;
    public GameObject cam_pc;
    public GameObject cam_player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A key was pressed");

            cam_pc.gameObject.SetActive(false);
            player.gameObject.SetActive(true);
            cam_player.gameObject.GetComponent<cam_focus_pc>().enabled = false;
            gameObject.GetComponent<utilisation_pc>().resolu = true;
            gameObject.GetComponent<big_doors>().enabled = true;

        }
    }
}
