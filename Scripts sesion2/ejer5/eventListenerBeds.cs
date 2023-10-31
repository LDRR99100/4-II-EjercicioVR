using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventListenerBeds : MonoBehaviour
{
    public eventCreator notificador;
    public Rigidbody rbb;
    void Start()
    {
        notificador.callMoveBeds += moveRightToLeft;
        rbb = gameObject.AddComponent<Rigidbody>();
        rbb.constraints = RigidbodyConstraints.FreezePositionY;
    }

    // Update is called once per frame
    void moveRightToLeft()
    {
        transform.Translate(Vector3.left * 5 * Time.deltaTime);
    }
}
