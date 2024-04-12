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
        rigidbody.velocity = new Vector3();

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);


        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            rigidbody.velocity += transform.forward * moveSpeed;
        }
        else if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) {
            rigidbody.velocity += -transform.forward * moveSpeed;
        }        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
            rigidbody.velocity += -transform.right * moveSpeed * 2;
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
            rigidbody.velocity += transform.right * moveSpeed * 2;
        }
    }

    public void Disable () {
        rigidbody.velocity = new Vector3();
        rigidbody.isKinematic = true;
        this.enabled = false;
    }

    public void Enable () {
        rigidbody.isKinematic = false;
        this.enabled = true;
    }
}
