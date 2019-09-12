using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CabinetScript : MonoBehaviour
{
    public bool hasCollided = false;
    public Text MainText;
    public Text cabinText;

    
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

        MainText.text = cabinText.text;

        
    }
}
