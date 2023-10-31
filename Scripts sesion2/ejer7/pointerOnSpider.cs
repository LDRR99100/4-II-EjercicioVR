using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointerOnSpider : MonoBehaviour
{
    public bool gazedAt;
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        gazedAt = false;
    }

    // Update is called once per frame
    void OnPointerEnter()
    {   
        gazedAt = true;
        power = 0;
        if(power == 50) {
            Destroy(this);
        }
    }
    void OnPointerExit() {
        gazedAt = false;
    }
    void Update() {
        while(gazedAt) {
        power++;
        }
        Debug.Log(power);
    }

}
