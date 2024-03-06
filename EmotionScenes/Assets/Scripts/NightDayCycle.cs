using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightDayCycle : MonoBehaviour
{
    [SerializeField] float speedx = 0f, speedy = 5f, speedz = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * speedx);
        transform.Rotate(Vector3.up * Time.deltaTime * speedy);
        transform.Rotate(Vector3.forward * Time.deltaTime * speedz);
    }
}
