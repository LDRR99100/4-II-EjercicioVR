using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventListenerChair : MonoBehaviour
{
    public eventCreator notificador;
    public Rigidbody rbc;
    void Start()
    {
        notificador.callJumpChairs += jumpChairs;
        rbc = gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void jumpChairs()
    {
        rbc.AddForce(transform.up * 3, ForceMode.Impulse);
    }
}
