using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickShowItem : MonoBehaviour
{
    public GameObject showItem;
    private void OnMouseDown(){
        if(showItem.activeInHierarchy){
            showItem.SetActive(false);
        }
        else{
            showItem.SetActive(true);
        }
    }
}
