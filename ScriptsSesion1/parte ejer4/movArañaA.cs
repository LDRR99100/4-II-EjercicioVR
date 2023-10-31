using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//cambie unos pequeños detalles respecto a la semana pasada pero es mayormente el mismo script
public class movArañaA : MonoBehaviour
{
    public float speed = 0.0f;
    public Vector3 direction;
    public bool collided;
    public Rigidbody rbw;
    public Rigidbody rbc;
    // Start is called before the first frame update
    void Start()
    {
        GameObject chair = GameObject.Find("Iron chair");
        gameObject.GetComponent<Transform>().position = new Vector3(chair.transform.position[0] + 0.25f, chair.transform.position[1] + 0.25f, chair.transform.position[2]);
        GameObject woodenTable = GameObject.Find("Wooden table");
        rbw = woodenTable.AddComponent<Rigidbody>();
        rbc = chair.AddComponent<Rigidbody>();
        rbw.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        GameObject chair = GameObject.Find("Iron chair");
        GameObject table = GameObject.Find("Wooden table");
        direction = table.transform.position - chair.transform.position;
        direction = new Vector3(direction[0], 0, direction[2]);
        if(!collided) {
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        speed = 5.0F;
    }

    void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Wooden table") {
            collided = true;
        }
    }
}
