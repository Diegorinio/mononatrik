using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kalendarzyk : MonoBehaviour
{
    public GameObject dateShow;
    private void OnMouseDown()
    {
        bool isCalendar = dateShow.active;
        if (isCalendar)
        {
            dateShow.SetActive(false);
        }
        else
        {
            dateShow.SetActive(true);
            StartCoroutine(hide());
        }
    }

    IEnumerator hide()
    {

        yield return new WaitForSeconds(2);
        dateShow.SetActive(false);
    }
}
