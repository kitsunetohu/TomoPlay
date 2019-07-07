using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EveTrigger : MonoBehaviour
{
    bool isTriggered=false;
    public bool isKey=false;
    public bool isSecDoor=false;
    string[] nowTlak; 
    public int talkNum;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void ChangeScene()
    {
       
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         if (talkNum==1)
        {
            nowTlak=UIManger.Instance.talk1;
        }
        else if (talkNum==2)
        {
            nowTlak=UIManger.Instance.talk2;
        }
        else if (talkNum==3)
        {
            nowTlak=UIManger.Instance.talk3;
        }else if (talkNum==4)
        {
            nowTlak=UIManger.Instance.talk4;
        }else if (talkNum==5)
        {
            nowTlak=UIManger.Instance.talk5;
        }else if (talkNum==6)
        {
            nowTlak=UIManger.Instance.talk6;
        }
        
        UIManger.Instance.TalkStart(nowTlak);
        if(isKey&&other.tag=="Player"&&isTriggered==false){
            isTriggered=true;
            GameManger.Instance.KeyNum++;
        }
        gameObject.SetActive(false);

    }
}
