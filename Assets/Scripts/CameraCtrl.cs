using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        if(Player==null){
            Player=GameObject.FindGameObjectWithTag("Player").transform;
        }

        Update();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Player.position-10*Vector3.forward;
    }
}
