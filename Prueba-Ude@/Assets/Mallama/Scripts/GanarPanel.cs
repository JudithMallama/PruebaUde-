using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class GanarPanel : MonoBehaviour
{
    UIDocument menu;
    Button btnPlay;
    Button btnMenu;
    Button btnSalir;


    private void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;

        btnPlay = root.Q<Button>("Play");
        btnMenu = root.Q<Button>("Menu");
        btnSalir = root.Q<Button>("Salir");

        btnPlay.clicked += LoadGameScene;
        btnMenu.clicked += LoadMenuScene;
        btnSalir.clicked += ExitGame;

        void LoadGameScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }

        void LoadMenuScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Play");
        }

        void ExitGame()
        {
            Application.Quit();
        }

    }
}
