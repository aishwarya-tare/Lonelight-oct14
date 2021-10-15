using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoHideUI : MonoBehaviour
{
    //public GameObject uiSystem;
    public GameObject riddle;

    private void Update() {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            //uiSystem.SetActive(true);
            riddle.SetActive(true);
            CancelInvoke("HideUISystem");
        }                                           
        else {
            Invoke("HideUISystem", 5);
        }
    }

    void HideUISystem() {
        // uiSystem.SetActive(false);
        riddle.SetActive(false);
    }
}
