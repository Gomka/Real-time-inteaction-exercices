using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TouchTrigger : MonoBehaviour
{
    public Texture myImage;
    public Image imagePanel;

    private void OnTriggerEnter(Collider other)
    {
        imagePanel.enabled = true;
        imagePanel.material.SetTexture("_MainTex", myImage);
    }

    private void OnTriggerExit(Collider other)
    {
        imagePanel.enabled = false;
    }
}
