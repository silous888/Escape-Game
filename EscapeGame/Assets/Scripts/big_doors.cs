using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class big_doors : MonoBehaviour
{
    public GameObject left;
    public GameObject right;
    public int doors_type;
    Vector3 vec;
    float pos;
    bool open;
    public AudioClip zuee;
    bool play_sound_ouverture;
    bool play_sound_fermeture;
    // Start is called before the first frame update
    private void Start()
    {
        if (doors_type == 1)
        {
            vec = Vector3.left;
            pos = left.transform.position[0];
        }
        if (doors_type == 2)
        {
            vec = Vector3.down;
            pos = left.transform.position[2];
        }
        if (doors_type == 3)
        {
            vec = Vector3.up;
            pos = left.transform.position[2];
        }
        play_sound_ouverture = true;
        play_sound_fermeture = false;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        open = left.GetComponent<info_ouverture>().ouvert;

        if ((doors_type == 1) && (Mathf.Abs(left.transform.position[0] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[0];
        }
        if ((doors_type == 2) && (Mathf.Abs(left.transform.position[2] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[2];
        }
        if ((doors_type == 3) && (Mathf.Abs(left.transform.position[2] - pos) > 3))
        {
            gameObject.GetComponent<big_doors>().enabled = false;
            left.GetComponent<info_ouverture>().ouvert = !open;
            pos = left.transform.position[2];
        }


        if (!open)
        {
            //print("ouverture");
            left.transform.Translate(vec *5.0f* Time.deltaTime, Space.Self);
            right.transform.Translate(-vec * 5.0f*Time.deltaTime, Space.Self);

            if (play_sound_ouverture)
            {
                play_sound_ouverture = false;
                play_sound_fermeture = true;
                left.GetComponent<AudioSource>().PlayOneShot(zuee, 0.7f);
            }
            
        }
        else
        {
            //print("fermeture");
            left.transform.Translate(-vec *5.0f* Time.deltaTime, Space.Self);
            right.transform.Translate(vec *5.0f* Time.deltaTime, Space.Self);

            if (play_sound_fermeture)
            {
                play_sound_fermeture = false;
                play_sound_ouverture = true;
                left.GetComponent<AudioSource>().PlayOneShot(zuee, 0.7f);
            }
        }
    
   

    }

}
