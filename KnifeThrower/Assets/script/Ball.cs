using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float Rotationspeed ; 
    public GameManager gameman ; 

    void Update()
    {
        this.transform.Rotate(Vector3.forward * -Rotationspeed * Time.deltaTime);
        
    }
void OnTriggerEnter2D(Collider2D col) 
    {
        
        // UI 
        if(col.CompareTag("bullet"))
        {
            gameman.setScore() ; 
           fire fi = col.GetComponent<fire>() ; 
            fi.speed = 0 ; 
            col.transform.SetParent(transform);
            col.tag = "bulletx" ; 

        }

    }

    
}
