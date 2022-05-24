using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cadavre_detector : MonoBehaviour
{
    bool play_cadavre;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        play_cadavre = true;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        //check if the collider is tagged as "Player" this time.
        if (other.tag == "Player")
        {
            cam.GetComponent<voice_gestion>().cadavre_play();
            gameObject.SetActive(false);
        }
    }
}
