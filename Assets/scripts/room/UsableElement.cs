using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsableElement : MonoBehaviour
{
    public Sprite[] states = new Sprite[2];
    public Image imageRenderer;
    Vector3 original;
    public float resizeValue = 0.2f;
    private void Start()
    {
        original = transform.localScale;
        imageRenderer = GetComponent<Image>();
        
    }
    private void OnMouseOver()
    {
        imageRenderer.sprite = states[1];
        resize(resizeValue);
    }
    private void OnMouseExit()
    {
        imageRenderer.sprite = states[0];
        resize(0);
    }

    private void resize(float v)
    {
        transform.localScale = new Vector3(original.x + v, original.y + v, original.z + v);
    }
}