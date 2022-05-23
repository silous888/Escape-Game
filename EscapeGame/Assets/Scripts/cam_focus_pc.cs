using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_focus_pc : MonoBehaviour
{
    public GameObject player;
    public GameObject cam_pc;
    public GameObject cam_player;
    public GameObject pc;
    public float smoothSpeed = 0.05f;
    public float x, y, z;
    Vector3 pos_origin;
    public int num_enigme;
    private void Start()
    {
        pos_origin = cam_player.transform.position;
       
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 dir = cam_pc.transform.TransformDirection(Vector3.forward);
        dir = dir.normalized;
        Vector3 desiredPosition = cam_pc.transform.position+dir+ new Vector3(x, y, z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(pc.transform.position);

        if (cond())
        {

            
            cam_pc.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
            pc.GetComponent<Outline>().enabled = false;
            //gameObject.GetComponent<utilisation_pc>().resolu = true;
            if(num_enigme==1)pc.GetComponent<enigme_1>().enabled = true;
            //if (num_enigme == 2) pc.GetComponent<enigme_2>().enabled = true;
            cam_player.transform.position = pos_origin;
            //Cursor.lockState = CursorLockMode.None;
        }

        bool cond()
        {
            return ((Mathf.Abs(cam_pc.transform.position[2] - cam_player.transform.position[2]) < 0.2f)) && ((Mathf.Abs(cam_pc.transform.position[0] - cam_player.transform.position[0]) < 0.2f));
        }


    }
}
