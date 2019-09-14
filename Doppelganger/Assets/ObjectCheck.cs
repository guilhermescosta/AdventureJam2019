using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCheck : MonoBehaviour
{
    public bool hasCollided = false;
    public string objectText;
    public Text MainText;


    
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

        MainText.text = objectText;

        
    }
}
