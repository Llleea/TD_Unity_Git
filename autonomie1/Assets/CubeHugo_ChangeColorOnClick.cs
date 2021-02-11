using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHugo_ChangeColorOnClick : MonoBehaviour
{
    private float state = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        if (state == 0)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            state = 1;
        }
        else if (state == 1)
        {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.blue);
            state = 0;
        }
    }
}
