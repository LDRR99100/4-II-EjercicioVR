using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script lo habia empezado pero borre lo que tenia pues no funcionaba por lo que en la entrega anterior esta vacio.
public class movArañaB : MonoBehaviour
{
    public Vector3 positionA;
    public Vector3 positionB;
    public float speed = 0.0f;
    public Vector3 direction;
    public bool pointB = false;
    public bool pointA = true;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 originalPosition = gameObject.transform.position;
        positionA = new Vector3(Random.Range(originalPosition[0], originalPosition[0] + 3.0f), 0.17f , Random.Range(originalPosition[2], originalPosition[2] + 3.0f));
        positionB = new Vector3(Random.Range(originalPosition[0], originalPosition[0] + 3.0f), 0.17f , Random.Range(originalPosition[2], originalPosition[2] + 3.0f));
        gameObject.transform.position = positionA;

    }
    // Update is called once per frame
    void Update()
    {

        speed = 3.0f;
        if(!pointB && pointA) {
        direction = positionB - positionA; 
        transform.position = Vector3.MoveTowards(transform.position, positionB, speed * Time.deltaTime);
        }
        if(!pointA && pointB) {
        transform.position = Vector3.MoveTowards(transform.position, positionA, speed * Time.deltaTime);
        }

        if(transform.position == positionB) {
            pointB = true;
            pointA = false;
            
        }
         if(transform.position == positionA) {
            pointB = false;
            pointA = true;    
        }
    }
    }
