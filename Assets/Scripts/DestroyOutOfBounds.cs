using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30f, lowerBound = -20f;

    // Update is called once per frame
    void Update()
    {
        // Destruir proyectiles
        if(transform.position.z > topBound)
        {
            Destroy(this.gameObject);
        }

        // Destruir enemigos
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(this.gameObject);

            // Congelar tiempo (En condición de game over)
            Time.timeScale = 0;
        }
    }
}
