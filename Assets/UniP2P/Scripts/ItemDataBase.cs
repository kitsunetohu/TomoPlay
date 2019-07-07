using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemDataBase : MonoBehaviour
{
    //リスト化をして下のvoid Start内でリストに値を追加、値は適当です  
    public List<Item> items = new List<Item>();

    private void Pick(string name, string desc)
    {
        if (name == null)
        {
            throw new System.ArgumentNullException(nameof(name));
        }
        else
        {
            items.Add(new Item(name, desc));
        }
    }
}