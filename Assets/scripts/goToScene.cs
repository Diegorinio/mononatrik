using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class goToScene : MonoBehaviour
{
    public string sceneID;
    public void OnMouseDown()
    {
        SceneManager.LoadScene(sceneID, LoadSceneMode.Single);
        Debug.Log($"go to scene {sceneID}");
    }
}
