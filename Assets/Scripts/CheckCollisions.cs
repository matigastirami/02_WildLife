using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Solo destruye si es un proyectil, esto es para evitar que el jugador sea afectado si se le coloca un Rigid Body
        if (other.CompareTag("Projectile"))
        {
            // Destruye el animal
            Destroy(this.gameObject);

            // Destruye el proyectil
            Destroy(other.gameObject);
        }
        
    }
}
