using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    public GameObject alarm;
    public GameObject laser;
    public float periode;
    bool toggle = false;
    float time_left;
    float time_start;

    public GameObject cam;
    public AudioClip impact;
    public AudioClip boom;
    public AudioClip zuee;
    AudioSource audioSource;
    bool p_impact;
    bool p_explo;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        p_impact = true;
        p_explo = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        time_start += Time.deltaTime;
        
        if (p_impact)
        {
            audioSource.PlayOneShot(impact, 1.2F);
            p_impact = false;
        }

        if ((time_start > 10f)&& (time_start < 20f))
        {
            
            if ((p_explo)&& (time_start > 11f))
            {

                gameObject.GetComponent<CameraShake>().enabled = true;
                audioSource.PlayOneShot(boom, 0.7F);
                p_explo = false;
            }
           


            if ((time_start > 12f) && (time_start < 17f))
            {

                time_left += Time.deltaTime;
                if (time_left > periode)
                {
                    if (toggle)
                    {
                        audioSource.PlayOneShot(zuee, 0.7F);
                        laser.gameObject.SetActive(false);
                        
                    }
                    else laser.gameObject.SetActive(true);
                    
                    time_left = 0f;
                    toggle = !toggle;
                }
            }
            else if (time_start > 17f)
            {
                gameObject.GetComponent<CameraShake>().enabled = false;
                laser.gameObject.SetActive(false);
                alarm.gameObject.SetActive(true);
            }
        }
        
    }
}
