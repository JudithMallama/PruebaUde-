using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Items : MonoBehaviour
{
    [System.Serializable]
    public class items
    {
        public int id;
        public string name;
        public string description;
        public Sprite image;
    }

}
