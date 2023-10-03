using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableObjectWithClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log($"Disabled {gameObject.name}");
        gameObject.SetActive(false);
    }
}
