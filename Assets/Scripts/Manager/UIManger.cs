using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManger : Manager<UIManger>
{
    bool isTalking=false;
    public Graphic talkPanel;
    public Image UnitySlot;
    public Image YukoSlot;

    [SerializeField]
    string[] talk1;
    [SerializeField]
    string[] talk2;
    [SerializeField]
    string[] talk3;
    [SerializeField]
    string[] talk4;

    string[] nowTalk;
    IEnumerator talksIenu;
    // Start is called before the first frame update
    void Start()
    {
        isTalking=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return)&&(isTalking==false)){
            Debug.Log("sd");
            TalkStart(talk1);
            
        }
        if(isTalking){
            if(talkPanel.gameObject.activeSelf==false){
                talkPanel.gameObject.SetActive(true);
            }
             
            if (Input.GetKeyDown(KeyCode.Return))
            {
                if (talksIenu.MoveNext())
                {//話はまだ終わっていない,UIに更新させて
                GameManger.Instance.userCanMove=false;
                    UIManger.Instance.TalkUIUpdata(talksIenu.Current as string);
                }
                else
                {
                    GameManger.Instance.userCanMove=true;
                    talkPanel.gameObject.SetActive(false);
                    isTalking=false;              
                }
            }
        }
    }

     public void TalkStart(string[] talks)
    {
        isTalking=true;
        nowTalk=talks;
        talksIenu = nowTalk.GetEnumerator();
     
    }

    public void TalkUIUpdata(string talk)
    {
        if (talkPanel.gameObject.activeSelf != true)
        {
            //TalkPanelを開く
            talkPanel.gameObject.SetActive(true);
        }

        string[] talkKV=talk.Split(',');
        switch(talkKV[0]){
            case "0":
                UnitySlot.gameObject.SetActive(false);
                YukoSlot.gameObject.SetActive(false);
                break;
            case "1":
                UnitySlot.gameObject.SetActive(true);
                YukoSlot.gameObject.SetActive(false);
                break;
            case "2":
                UnitySlot.gameObject.SetActive(false);
                YukoSlot.gameObject.SetActive(true);
                break;
        }
        //トークUIを更新する
        talkPanel.GetComponentInChildren<Text>().text = talkKV[1];
    }
    public void hideTalk()
    {
        //トークUIを隠す
        talkPanel.gameObject.SetActive(false);
    }


}
