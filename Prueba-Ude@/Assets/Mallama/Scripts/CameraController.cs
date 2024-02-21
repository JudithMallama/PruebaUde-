using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player; // La referencia al Transform del jugador

    void LateUpdate()
    {
        // Obtener la posici�n actual de la c�mara
        Vector3 currentPosition = transform.position;

        // Mantener la posici�n de la c�mara igual a la posici�n del jugador
        currentPosition.x = player.position.x;
        currentPosition.z = player.position.z-5f;

        // Aplicar la nueva posici�n a la c�mara
        transform.position = currentPosition;
    }
}