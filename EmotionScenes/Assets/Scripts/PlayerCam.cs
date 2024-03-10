using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.Mathematics;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX = 100f, sensY = 100f, moveSpeed = 10f;
    private float xRotation, yRotation;
    private Rigidbody rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        rigidbody.velocity = new Vector3();

        if(Input.GetKey(KeyCode.W)) {
            rigidbody.velocity += transform.forward * moveSpeed;
        }
        else if(Input.GetKey(KeyCode.S)) {
            rigidbody.velocity += -transform.forward * moveSpeed;
        }        
        if(Input.GetKey(KeyCode.A)) {
            rigidbody.velocity += -transform.right * moveSpeed;
        }
        else if(Input.GetKey(KeyCode.D)) {
            rigidbody.velocity += transform.right * moveSpeed;
        }
    }
}
