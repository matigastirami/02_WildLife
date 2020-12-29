using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private float horizontalInput;

    [SerializeField]
    private float speed = 10f;

    [SerializeField]
    private float xRange = 18f;

    [SerializeField]
    private GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        // Movimiento personaje
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);


        // Si se sale el personaje hacia la izquierda
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        // Si se sale el personaje hacia la derecha
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Acciones personaje

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Espacio dispara un proyectil
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    /*
    * El siguiente código hace que no se salga de los bordes, la técnica es la más sencilla ya que no pone objetos invisibles que fuerzan el motor de física
    */
    private void checkObjectInBounds(int sign)
    {
        if (transform.position.x > sign * xRange)
        {
            transform.position = new Vector3(sign * xRange, transform.position.y, transform.position.z);
        }
    }


}
