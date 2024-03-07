using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDistorsion : MonoBehaviour
{
    [SerializeField] float timeToScale = 1f, speedToScale = 0.2f, maxScale = 2.5f, scalePeriod = 1.5f;
    public float targetScale = 2.5f, scaleTimer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        targetScale = Random.Range(0, maxScale);
    }

    // Update is called once per frame
    void Update()
    {
        scaleTimer += Time.deltaTime;

        if(scaleTimer > scalePeriod)
        {
            scaleTimer = 0f;
            targetScale = Random.Range(0, maxScale);
        }

        float newScale = Mathf.SmoothDamp(this.transform.localScale.z, targetScale, ref timeToScale, speedToScale);
        this.transform.localScale = new Vector3(this.transform.localScale.x, this.transform.localScale.y, newScale);

    }


}
