using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    [SerializeField] string sceneInfo;
    [SerializeField] Animator uiAnimator;
    [SerializeField] PlayerCam playerCam;

    void OnTriggerEnter(Collider other) {

        uiAnimator.SetTrigger("StartFade");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        playerCam.Disable();

        switch (sceneInfo)
        {
            case "sad": Debug.Log("Sad scene");
                break;
            case "surprise": Debug.Log("Surprise scene");
                break;
            case "relief": Debug.Log("Relief scene");
                break;
            case "joy": Debug.Log("Joy scene");
                break;
            default: Debug.Log(sceneInfo);
                break;

        }

    }
}
