using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubecolor : MonoBehaviour
{
    public float y = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        return;
    }
}
