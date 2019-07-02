using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        
    }

}
