using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorKaiguan : MonoBehaviour
{
    public Collider2D door;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

  

    void OnTriggerEnter2D(Collider2D other)
    {

       if(GameManger.Instance.KeyNum==0){
           UIManger.Instance.TalkStart(UIManger.Instance.talk4);
       }
       else if(GameManger.Instance.KeyNum==1)
       {
           UIManger.Instance.TalkStart(UIManger.Instance.talk5);
       }
       else
       {
           door.isTrigger=true;
       }
        

    }

}
