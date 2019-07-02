using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject _gun;
    public TextEffect _text;

    public bool isDeath;
    // Start is called before the first frame update
    void Start()
    {
        isDeath = false;
        _text = GameObject.FindGameObjectWithTag("gametext").GetComponent<TextEffect>();
        _gun = GameObject.Find("gun");
        if (_gun == null)
        {
            Death();
        }
        else {

            _text.fullText = "A shadow figure attacks you.";
            StartCoroutine(_text.ShowText());

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDeath && Input.GetKey(KeyCode.Escape) ) {
            SceneManager.LoadScene(0);
        }
    }

    public void Death() {
        
        _text.fullText = "A shadow figure attacks you. \nSadly, you dont' have any way to defend yourself and died. \n Press ESC to return to the Main Menu";
        StartCoroutine(_text.ShowText());
        isDeath = true;

    }
}
