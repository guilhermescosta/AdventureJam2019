using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetScript : MonoBehaviour
{
    public bool hasCollided = false;
    public GameObject MainText;
    public GameObject cabinText;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnMouseDown()
    {
        hasCollided = true;

        MainText = cabinText;

        Debug.Log("Click!");
    }
}
