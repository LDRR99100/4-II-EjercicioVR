using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventCreator : MonoBehaviour
{
    public delegate void delegateMethod();
    public event delegateMethod callMoveBeds;
    public event delegateMethod callJumpChairs;    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "bed with person with blood" || collision.gameObject.name == "broken bed" || collision.gameObject.name == "bed") {
            callMoveBeds();
            callJumpChairs();
        }
    }
}
