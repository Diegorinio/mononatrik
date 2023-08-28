using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickShowItem : MonoBehaviour
{
    public GameObject showItem;
    private void OnMouseDown(){
        if(showItem.active){
            showItem.SetActive(false);
        }
        else{
            showItem.SetActive(true);
        }
    }
}
