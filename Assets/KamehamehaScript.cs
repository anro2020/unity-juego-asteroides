using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamehamehaScript : MonoBehaviour
{
    Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        velocity.y = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        GetComponent<Rigidbody2D>().position += velocity; 
    }

    private void OnBecameInvisible() {
        //es decir, cuando el objeto sea invisible...
        Destroy(gameObject); //destruir el objecto instanciado
    }

    // void OnCollisionEnter2D(Collision2D collision)
    // {
    //     if (collision.gameObject.tag == "Asteroide") {
    //         Destroy(collision.gameObject);
    //     }
    // }
}
