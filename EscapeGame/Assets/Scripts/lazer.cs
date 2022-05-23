using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class lazer : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject prison;

    private void Start()
    {
        gameOver.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        //check if the collider is tagged as "Player" this time.
        if (other.tag == "Player")
        {
            gameOver.SetActive(true);
            prison.SetActive(false);

        }
    }
}
