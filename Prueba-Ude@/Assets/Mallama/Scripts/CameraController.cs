using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // La referencia al Transform del jugador

    void LateUpdate()
    {
        // Obtener la posición actual de la cámara
        Vector3 currentPosition = transform.position;

        // Mantener la posición de la cámara igual a la posición del jugador
        currentPosition.x = player.position.x;
        currentPosition.z = player.position.z-5f;

        // Aplicar la nueva posición a la cámara
        transform.position = currentPosition;
    }
}