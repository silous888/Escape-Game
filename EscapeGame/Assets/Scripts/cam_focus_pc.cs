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

    private void Start()
    {

       
      
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

        if (((Mathf.Abs(cam_pc.transform.position[2] - cam_player.transform.position[2]) <0.2f))&& ((Mathf.Abs(cam_pc.transform.position[0] - cam_player.transform.position[0]) < 0.2f)))
        {
            cam_pc.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
            gameObject.GetComponent<cam_focus_pc>().enabled = false;
        }
    }
}
