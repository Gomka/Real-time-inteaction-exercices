using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController player;
    [SerializeField] float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.Move(transform.forward * speed);
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.Move(transform.forward * -1 * speed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.Move(transform.right * -1 * speed);
        } else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.Move(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.down);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.down * -1);
        }

    }
}
