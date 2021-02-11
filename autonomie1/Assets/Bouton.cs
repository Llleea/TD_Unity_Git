using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouton : MonoBehaviour
{
    float hauteur = 1.5f;
    public GameObject cubeNouveau;

    // Start is called before the first frame update
    void Start()
    {
        cubeNouveau = GameObject.Find("CubeApparait");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Sphere")
        {
            //transform.Translate(0, 10f, 0, Space.World);
            Instantiate(cubeNouveau, new Vector3(4f, hauteur, -25f), Quaternion.identity);
            hauteur += 3;
        }
    }
}


