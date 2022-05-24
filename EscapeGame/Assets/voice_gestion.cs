using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class voice_gestion : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip [] boujenah;
    public AudioClip[] mdp;
    public AudioClip[] cadavre;
    public AudioClip[] papa;
    public AudioClip[] rapport;
    public AudioClip[] security;
    public AudioClip[] vaisseau;
    public AudioClip[] mecano;

    AudioClip audio;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void boujenah_play()
    {
        int length = boujenah.Length;
        audio = boujenah[Random.Range(0,length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void security_play()
    {
        int length = security.Length;
        audio = security[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void mdp_play()
    {
        int length = mdp.Length;
        audio = mdp[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void cadavre_play()
    {
        int length = cadavre.Length;
        audio = cadavre[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void papa_play()
    {
        int length = papa.Length;
        audio = papa[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void rapport_play()
    {
        int length = rapport.Length;
        audio = rapport[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void vaisseau_play()
    {
        int length = vaisseau.Length;
        audio = vaisseau[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }

    public void mecano_play()
    {
        int length = mecano.Length;
        audio = mecano[Random.Range(0, length)];
        audioSource.PlayOneShot(audio, 0.7F);
    }
}
