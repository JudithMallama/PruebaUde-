using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollectItems : MonoBehaviour
{
    public Inventory inventory;
    public AudioSource quienEmite;
    public AudioClip sound;
    public float volume = 1;
    public int puntos=0;

    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntos=inventory.quantity++;
            Destroy(gameObject);
            quienEmite.PlayOneShot(sound, volume);

            MainPanel mainPanel = FindObjectOfType<MainPanel>();
            if (mainPanel != null)
            {
                mainPanel.puntos = inventory.quantity;
            }

            Debug.Log("Este es un comentario en la consola." + puntos);

            if (puntos==4)
            {
                SceneManager.LoadScene("Ganar");
            }


        }
     
     


    }
    
}