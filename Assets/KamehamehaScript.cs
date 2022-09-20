using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KamehamehaScript : MonoBehaviour
{
    Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        float num2 = PlayerPrefs.GetFloat("num2");
        float num3 = PlayerPrefs.GetFloat("num3");

        velocity.y = num3;
        velocity.x = -num2;
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
}
