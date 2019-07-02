using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public string[] texts;
    public int index = 0;

    public TextEffect _effect;

    // Start is called before the first frame update
    void Start()
    {
        _effect = GameObject.FindGameObjectWithTag("gametext").GetComponent<TextEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(9);
        }

        // texto -> clica -> texto +1

        if (_effect.endText == false && index <= texts.Length )
        {
            if (index == 0) {
                _effect.fullText = texts[index];
                StartCoroutine(_effect.ShowText());
                index++;
                _effect.endText = false;
            }
            else if (Input.GetMouseButtonDown(0)) { 
            _effect.fullText = texts[index];
            StartCoroutine(_effect.ShowText());
            index++;
             }
        }
        
    }
}
