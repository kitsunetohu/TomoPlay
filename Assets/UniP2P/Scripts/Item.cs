using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]//この属性を使ってインスペクター上で表示
public class Item
{
    public string itemName;        //名前
    public string itemDesc;        //アイテムの説明文
    public Texture2D itemIcon;     //アイコン

    //アイテムタイプも同じくenum      

    //ここでリスト化時に渡す引数をあてがいます   
    public Item(string name, string desc)
    {
        itemName = name;
        //アイコンはnameとイコールにするのでアイコンがあるパス＋nameで取ってきます    
        itemIcon = Resources.Load<Texture2D>("Item Icons/" + name);
        itemDesc = desc;
    }

}
