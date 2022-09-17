using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveScript : MonoBehaviour
{
    int hp = 5;
    public GameObject spawn_kamehameha;
    Vector2 velocity;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position_current = transform.position;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            velocity.x = -0.2f; //afecta la fuerza de empuje
            // position_current.x -= 5; // * afecta los pixeles
            // Debug.Log("IZQ");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            velocity.x = 0.2f;
            // position_current.x += 5;
            // Debug.Log("DER");
        }
        // transform.position = position_current;
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) velocity.x = 0;

        // Crear Disparo
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate -> es para crear una instancia
            // primer atributo, es el objeto que quiero instanciar)
            // segundo parametro, es para indicarle la posicion del objeto instanciado 
            // y el tercero, es una propiedad para la rotacion
            Vector3 pos = transform.position;
            // for (var i = 0; i < 3; i++)
            // {
            // }
                GameObject skamehameha = Instantiate(spawn_kamehameha, pos, Quaternion.identity);
                // pos = pos.y = -1;
                // GameObject skamehameha = Instantiate(spawn_kamehameha, transform.position, Quaternion.identity);
                // Thread.Sleep(1000);
        }

    }
    
    private void FixedUpdate() {
        // Diferencia con Update, es un metodo que ejecuta el numero de veces que se ejecuta 1 cuadro es decir 60 por segundo en 60fps
        // * y el FixedUpdate, es para poner las magnitudes fisicas, ya que ajusta la constancia de a cuanto corre el juego, no importa si baja brusco o sutil su fps

        GetComponent<Rigidbody2D>().position += velocity; //Componente que sirve para empujar
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroide") {
            Destroy(collision.gameObject);
            hp--;
        }
        if (hp == 0) {
            Destroy(gameObject);
        }
    }
}