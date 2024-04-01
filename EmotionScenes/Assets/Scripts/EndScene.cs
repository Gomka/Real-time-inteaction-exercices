using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EndScene : MonoBehaviour
{
    [SerializeField] string sceneInfo;

    void OnTriggerEnter(Collider other) {
        switch (sceneInfo)
        {
            case "sad": Debug.Log("Sad scene");
                break;
            case "surprise":
                break;
            case "relief":
                break;
            case "joy":
                break;
            default: 
                break;

        }

    }
}
