using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameOver : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined; 

    }

    public void ButtonRetourMenu()
    {
        // Play Now Button has been pressed, here you can initialize your game (For example Load a Scene called GameLevel etc.)
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }


}