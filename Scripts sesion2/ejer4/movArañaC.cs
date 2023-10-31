using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este script no estaba hecho.
public class movArañaC : MonoBehaviour
{
    public Rigidbody rbc;
    public bool Grounded;
    // Start is called before the first frame update
    void Start()
    {
        rbc = gameObject.AddComponent<Rigidbody>();
        Grounded = true;
        rbc.constraints = RigidbodyConstraints.FreezeRotation;
    }

    public void Update()
    {
        if(Grounded) {
            rbc.AddForce(transform.up * 5, ForceMode.Impulse);
            Grounded = false;
        }
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Room") {
            Grounded = true;
        }
    }
}
