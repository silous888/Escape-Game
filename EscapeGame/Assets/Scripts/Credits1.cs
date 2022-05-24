using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public float speed;

    float positionY = 0f;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            speed += 1f;
        }
        if (Input.GetMouseButtonDown(1) && speed > 1f)
        {

            speed -= 1f;
        }

        transform.Translate(0, -speed, 0);

        positionY = transform.position.y;

        if (positionY<-4500)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("prison");
            print("Ici Camden Curtis, au rapport");
        }
    }
}
