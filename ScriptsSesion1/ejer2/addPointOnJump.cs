using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addPointOnJump : MonoBehaviour
{
    public int puntuacion = 0;
    // Start is called before the first frame update
    void Start()
    {
        puntuacion = 0;
    }

    void Update() 
    {
        Debug.Log("La puntuancion es de: " + puntuacion);
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "spider") {
            puntuacion += 10;
        }
    }
}
