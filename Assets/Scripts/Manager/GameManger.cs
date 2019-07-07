using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : Manager<GameManger>
{
    public bool userCanMove=true;
    public string lastScene;
    public string nowScene="TitleScene";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            changeSceneTo("CONGXI 1");
        }
    }

   public void changeSceneTo(string nextScene){
       lastScene=nowScene;
       SceneManager.LoadSceneAsync(nextScene,LoadSceneMode.Single);
   }
}
