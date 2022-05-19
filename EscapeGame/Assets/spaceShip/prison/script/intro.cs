using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject laser;
    public float periode;
    bool toggle = false;
    float time_left;
    float time_start;

    public AudioClip impact;
    public AudioClip boom;
    public AudioClip zuee;
    AudioSource audioSource;
    bool play;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        play = true;
    }
    // Update is called once per frame
    void Update()
    {
        time_start += Time.deltaTime;
        
        if(play) audioSource.PlayOneShot(impact, 0.7F);

        if (time_start > 20f)
        {
            if (time_start < 25f)
            {
                time_left += Time.deltaTime;
                if (time_left > periode)
                {
                    if (toggle)
                    {
                        laser.gameObject.SetActive(false);
                        audioSource.PlayOneShot(zuee, 0.7F);
                    }

                    else laser.gameObject.SetActive(true);
                    
                    time_left = 0f;
                    toggle = !toggle;
                }
            }
            else
            {
                laser.gameObject.SetActive(false);
            }
        }
        
    }
}
