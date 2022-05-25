using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enigme_1 : MonoBehaviour
{
    public GameObject prison;
    public GameObject gameOver;
    public GameObject player;
    public GameObject cam_pc;
    public GameObject cam_player;
    public Texture[] Question;
    public int error;
    public int nb_erreurMax;
    float time;
    bool[] repondu;
    int question_actuelle;
    KeyCode[] keys;
    bool play_mdp_oublie;

    // Start is called before the first frame update
    void Start()
    {
        error = 0;
        repondu = new bool[Question.Length];
        for (int i = 0; i < repondu.Length; i++)
        {
            repondu[i] = false;
        }
        question_actuelle = 1;

        keys = new KeyCode[4] { KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D};
        play_mdp_oublie = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play_mdp_oublie)
        {
            play_mdp_oublie = false;
            cam_pc.GetComponent<voice_gestion>().mdp_play();
        }
        time += Time.deltaTime;
        if (time > 5.0f)
        {

            if( (question_actuelle==6)|| (error >= nb_erreurMax))
            {
                print("fin enigme 1");

                cam_pc.gameObject.SetActive(false);
                player.gameObject.SetActive(true);
                cam_player.gameObject.GetComponent<cam_focus_pc>().enabled = false;

                if (error >= nb_erreurMax)
                {
                    gameOver.SetActive(true);
                    prison.SetActive(false);
                }
                
                gameObject.GetComponent<utilisation_pc>().resolu = true;
                gameObject.GetComponent<big_doors>().enabled = true;
                gameObject.GetComponent<enigme_1>().enabled = false;

            }
            else if(initializeQuestion(question_actuelle - 1)) question_actuelle += 1;
        }     
    }



    bool initializeQuestion(int numQuestion)
    {

        if (!repondu[numQuestion]) gameObject.GetComponent<Renderer>().material.SetTexture("_EmissionMap", Question[numQuestion]);
        if (reponse(numQuestion)) repondu[numQuestion] = true;
        
        return repondu[numQuestion];
    }

    bool reponse(int numQuestion)
    {
     
        switch (numQuestion)
        {
            case 0:
                if (Input.GetKeyDown(keys[0])) return true;
                else if ((Input.GetKeyDown(keys[1])) || (Input.GetKeyDown(keys[2])) || (Input.GetKeyDown(keys[3])))
                {
                    error++;
                    cam_player.GetComponent<voice_gestion>().error_play();
                }
                break;

            case 1:
                if (Input.GetKeyDown(keys[1])) return true;
                else if ((Input.GetKeyDown(keys[0])) || (Input.GetKeyDown(keys[2])) || (Input.GetKeyDown(keys[3])))
                {
                    error++;
                    cam_player.GetComponent<voice_gestion>().error_play();
                }
                break;

            case 2:
                if (Input.GetKeyDown(keys[1])) return true;
                else if ((Input.GetKeyDown(keys[0])) || (Input.GetKeyDown(keys[2])) || (Input.GetKeyDown(keys[3])))
                {
                    error++;
                    cam_player.GetComponent<voice_gestion>().error_play();
                }
                break;
            case 3:
                if (Input.GetKeyDown(keys[2])) return true;
                else if ((Input.GetKeyDown(keys[0])) || (Input.GetKeyDown(keys[1])) || (Input.GetKeyDown(keys[3])))
                {
                    error++;
                    cam_player.GetComponent<voice_gestion>().error_play();
                }
                break;
            case 4:
                if (Input.GetKeyDown(keys[1])||Input.GetKeyDown(keys[0])) return true;
                break;
        }
        return false;
    }
}



