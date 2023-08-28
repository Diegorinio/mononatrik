using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableobjectwithclick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Wypierdol");
        gameObject.SetActive(false);
    }
}
