using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
#if ENABLE_INPUT_SYSTEM && STARTER_ASSETS_PACKAGES_CHECKED
using UnityEngine.InputSystem;
#endif
public class pc_corridor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cam;
    public Text elec_issue;
    public Text use_keys;
    public Text not_all_keys;
    public GameObject player;
    public AudioClip doorSound;
    AudioSource audioSource;
    float time;
    bool e_pressed;
    public GameObject panel_fin;
    private void Start()
    {
        audioSource = cam.GetComponent<AudioSource>();
        e_pressed = false;
    }
    // Update is called once per frame
    void Update()
    {
        Text text = elec_issue;
        if (player.GetComponent<inventaire>().elecRepare)
        {
            if (key_cond())
            {
                text = use_keys;
                elec_issue.enabled = false;
                not_all_keys.enabled = false;
            }
            else
            {
                text = not_all_keys;
                elec_issue.enabled = false;
                use_keys.enabled = false;
            }
        }
        
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.TransformDirection(Vector3.forward), out hit, 5))
        {
            if (hit.transform.gameObject == gameObject)
            {
                gameObject.GetComponent<Outline>().enabled = true;
                text.enabled = true;
                if ((Input.GetKeyDown(KeyCode.E))&&(key_cond())&& (player.GetComponent<inventaire>().elecRepare)&&(!e_pressed))
                {
                    print("e key was pressed");
                    //Cursor.lockState = CursorLockMode.Confined;
                    panel_fin.SetActive(true);
                    audioSource.PlayOneShot(doorSound, 1.2F);
                    e_pressed = true;
                    cam.GetComponent<voice_gestion>().boujenah_play();


                }
            }
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
            text.enabled = false;
        }

        if (e_pressed)
        {
            time += Time.deltaTime;
            if (time > 4.5f)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("SceneEpilogue");
            }
        }

    }

    private bool key_cond()
    {
        return ((player.GetComponent<inventaire>().key_blue) && (player.GetComponent<inventaire>().key_red) && (player.GetComponent<inventaire>().key_green));
    }
}
