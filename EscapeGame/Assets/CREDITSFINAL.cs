using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsFinal : MonoBehaviour
{
    public float speed;
    public float limit;
    float positionY = 0f;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            speed += 0.05f;
        }
        if (Input.GetMouseButtonDown(1) && speed > 1f)
        {

            speed -= 0.05f;
        }

        transform.Translate(0, -speed, 0);

        positionY = transform.position.y;

        if (positionY < limit)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
            print("Ici Camden Curtis, au rapport");
        }
    }
}
