using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invetory : MonoBehaviour
{
    public List<GameObject> items = new List<GameObject>();
    public static Invetory instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this ) {
            Destroy(gameObject);
        }


        DontDestroyOnLoad(this);
      
        
    }

    private void Update()
    {
        
    }

}
