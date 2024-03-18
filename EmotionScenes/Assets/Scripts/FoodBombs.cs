using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBombs : MonoBehaviour
{
    [SerializeField] GameObject bomb;
    [SerializeField] float interval = 4f;
    private float scaleTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scaleTimer += Time.deltaTime;

        if(scaleTimer > interval)
        {
            scaleTimer = 0f;
            
            Instantiate(bomb, new Vector3(Random.Range(0, 32)-16, 1, Random.Range(0, 32)-16), transform.rotation);
        }
    }
}
