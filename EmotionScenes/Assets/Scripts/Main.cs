using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField] int cubeCount = 10;
    [SerializeField] List<Texture> allStimuli = new List<Texture>();
    [SerializeField] Image quad;

    // Start is called before the first frame update
    void Start()
    {
        allStimuli.AddRange(Resources.LoadAll<Texture>("set1"));
        GenerateStim(cubeCount);
    }

    void GenerateStim(int count)
    {
        for( int i = 0; i < count; i++)
        {
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);

            go.transform.position = new Vector3(i * 3, 1, 0);
            go.GetComponent<BoxCollider>().isTrigger = true;
            go.AddComponent<TouchTrigger>();

            Texture tex = allStimuli[Random.Range(0, allStimuli.Count)];

            go.GetComponent<TouchTrigger>().myImage = tex;
            go.GetComponent<TouchTrigger>().imagePanel = quad;
            go.GetComponent<Renderer>().material.SetTexture("_MainTex", tex);

        }
    }

}
