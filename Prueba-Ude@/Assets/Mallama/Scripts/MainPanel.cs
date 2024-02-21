using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainPanel : MonoBehaviour
{
    public int puntos;
    UIDocument menu;
    UIDocument enu;
    Label points;
    Button bntCerrar;
    Button b5;
    VisualElement cartas;
    VisualElement cart;

    Button iteme1;
    Button iteme2;
    Button iteme3;
    Button iteme4;
    Button iteme5;
    Button iteme6;
    Button iteme7;
    Button iteme8;
    Button iteme9;
    Label nombre; 
    ProgressBar velocidad; 
    ProgressBar fuerza; 
    ProgressBar magia; 
    ProgressBar resistencia; 
    Button back;

    void Start()
    {
        // Inicializa puntos si es necesario
        puntos = 0;
    }

    void Update()
    {
        enu = GetComponent<UIDocument>();
        VisualElement root = enu.rootVisualElement;
        points = root.Q<Label>("points");
        points.text = puntos.ToString()+ "/5";      
    }

    private void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        VisualElement root = menu.rootVisualElement;

        points = root.Q<Label>("points");
        bntCerrar = root.Q<Button>("btnCerrar");

        cartas = root.Q<VisualElement>("premios");
        cart = root.Q<VisualElement>("carta");
        b5 = root.Q<Button>("b5");
        iteme1 = root.Q<Button>("btn01");
        iteme2 = root.Q<Button>("btn02");
        iteme3 = root.Q<Button>("btn03");
        iteme4 = root.Q<Button>("btn04");
        iteme5 = root.Q<Button>("btn05");
        iteme6 = root.Q<Button>("btn06");
        iteme7 = root.Q<Button>("btn07");
        iteme8 = root.Q<Button>("btn08");
     
       

        nombre = root.Q<Label>("nombre");
        velocidad = root.Q<ProgressBar>("velocidad");
        fuerza = root.Q<ProgressBar>("fuerza");
        magia = root.Q<ProgressBar>("magia");
        resistencia = root.Q<ProgressBar>("resistencia");
        back = root.Q<Button>("back");

        //callbacks
 
        b5.RegisterCallback<ClickEvent>(abrirCart);
        iteme1.RegisterCallback<ClickEvent, int>(seleccionarCarta, 1);
        iteme2.RegisterCallback<ClickEvent, int>(seleccionarCarta, 2);
        iteme3.RegisterCallback<ClickEvent, int>(seleccionarCarta, 3);
        iteme4.RegisterCallback<ClickEvent, int>(seleccionarCarta, 4);
        iteme5.RegisterCallback<ClickEvent, int>(seleccionarCarta, 5);
        iteme6.RegisterCallback<ClickEvent, int>(seleccionarCarta, 6);
        iteme7.RegisterCallback<ClickEvent, int>(seleccionarCarta, 7);
        iteme8.RegisterCallback<ClickEvent, int>(seleccionarCarta, 8);
       
        back.RegisterCallback<ClickEvent>(volver);


        bntCerrar.clicked += LoadGameScene;
        void LoadGameScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
        }

        void abrirCart(ClickEvent evt)
        {
            cart.AddToClassList("carta-actva");
        }

       

        void volver(ClickEvent evt)
        {
            cart.RemoveFromClassList("carta-actva");
        }

        void seleccionarCarta(ClickEvent evt, int modelo)
        {
            Debug.Log("entro al envento");
            switch (modelo)
            {
                case 1:
                    Debug.Log("Entro al 1");
                    nombre.text = "Calculo";
                    velocidad.lowValue = 10;
                    fuerza.lowValue = 50;
                    magia.lowValue = 30;
                    resistencia.lowValue = 70;
                    break;
                case 2:
                    nombre.text = "Fisica";
                    velocidad.lowValue = 20;
                    fuerza.lowValue = 50;
                    magia.lowValue = 90;
                    resistencia.lowValue = 70;
                    break;
                case 3:
                    nombre.text = "Algebra";
                    velocidad.lowValue = 3;
                    fuerza.lowValue = 85;
                    magia.lowValue = 44;
                    resistencia.lowValue = 33;
                    break;
                case 4:
                    nombre.text = "Trigonometria";
                    velocidad.lowValue = 92;
                    fuerza.lowValue = 82;
                    magia.lowValue = 22;
                    resistencia.lowValue = 11;
                    break;
                case 5:
                    nombre.text = "Campos";
                    velocidad.lowValue = 40;
                    fuerza.lowValue = 30;
                    magia.lowValue = 28;
                    resistencia.lowValue = 52;
                    break;
                case 7:
                    nombre.text = "Circuitos";
                    velocidad.lowValue = 15;
                    fuerza.lowValue = 20;
                    magia.lowValue = 35;
                    resistencia.lowValue = 75;
                    break;
                case 8:
                    nombre.text = "Computacion";
                    velocidad.lowValue = 10;
                    fuerza.lowValue = 80;
                    magia.lowValue = 90;
                    resistencia.lowValue = 60;
                    break;
                default:
                    Debug.LogError("Modelo no reconocido.");
                    break;
            }
        }

    }

}


