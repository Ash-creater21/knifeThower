using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public float speed ; 
    private Rigidbody2D rb ; 
    public GameManager gameman ; 
    
    void Start()
    {
        gameman = FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>() ; 
    }

    // Update is called once per frame
    void Update()
    {
        // rb.AddForce(Vector2.up*speed,ForceMode2D.Force);
        rb.velocity = Vector2.up * speed  ; 
       
    }

    void OnTriggerEnter2D(Collider2D col) 
    {
        if(col.CompareTag("bulletx"))
        {
            gameman.isDead = false; 
            Destroy(this.gameObject);
            Destroy(col.gameObject); 

        }

    }
}
