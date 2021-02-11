using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBouleDebloquer : MonoBehaviour
{
    bool temoin = false;
   float vitesse = 0.02f;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown("space") && temoin )
        {
            temoin = false;
            transform.Translate(0, 1000 * Time.deltaTime, 0, Space.World);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(-vitesse, 0, 0, Space.World);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(vitesse, 0, 0, Space.World);
        }
        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, -vitesse, Space.World);
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, +vitesse, Space.World);
        }
        if (Input.GetKey("e"))
        {
            vitesse += 0.01f;
        }
        if (Input.GetKey("a"))
        {
            vitesse -= 0.01f;
        }
    }


        void OnMouseDown()
        {
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }

   void OnCollisionEnter(Collision collision)
    {
        
        temoin = true;
    }
}

