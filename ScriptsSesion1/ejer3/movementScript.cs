using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// En este script añadi una variable grounded para que solo pudiese saltar si esta sobre un objeto, evitando salto infinito
public class movementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rbc = gameObject.AddComponent<Rigidbody>();
        rbc.constraints = RigidbodyConstraints.FreezeRotation;
        rbc.drag = rbc.drag * 2;
    }
    public float speed;
    public Vector3 InputCollector;
    public Rigidbody rbc;
    public bool Grounded;
        // Update is called once per frame
    void Update()
    {
        InputCollector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate()
    {
        rbc.AddForce(InputCollector * 15);
        if (Input.GetButton("Jump"))
        {
            if(Grounded) {
            rbc.AddForce(transform.up * 5, ForceMode.Impulse);
            Grounded = false;
            }
        }
    }

    void OnCollisionEnter(Collision collision) {
            Grounded = true;
    }
}
