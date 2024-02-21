using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MenuPanel : MonoBehaviour
{
    void Start()
    {
        
        Button playButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("play");
        Button exitButton = GetComponent<UIDocument>().rootVisualElement.Q<Button>("salir");

        playButton.clicked += LoadGameScene;
        exitButton.clicked += ExitGame;
    }

    void LoadGameScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Play");
    }

    void ExitGame()
    {
        // Salir de la aplicación
        Application.Quit();
    }

}
