using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CambiarOpacidad : MonoBehaviour
{

    public Button b1;
    public Button b2;

    void Start()
    {
        // Obtener las referencias a los botones al inicio del juego
        b1 = GetComponent<UIDocument>().rootVisualElement.Q<Button>("b1");
        b2 = GetComponent<UIDocument>().rootVisualElement.Q<Button>("2");
    }


    void OnTriggerEnter(Collider other)
    {

        // Verificar si el jugador colisiona con el objeto E2
        if (other.CompareTag("E1"))
        {
            Debug.Log("Hola, mundo!");
           // Button button = uiDocument.rootVisualElement.Q<Button>("2");
           b1.style.opacity = 1.0f;
            // Cambiar la opacidad del botón al 100%
            
        }
    }
}
