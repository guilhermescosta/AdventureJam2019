using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{
    public bool alreadyVisit = false;
    public Text BackText;
    public Text GameText;
    public Button SouthBtn;
    public Scene currentScene;
    public Scene lastScene;

    private void Awake()
    {
        GameText = GameObject.FindGameObjectWithTag("gametext").GetComponent<Text>();

        currentScene = SceneManager.GetActiveScene();
        
    }





    /*
    void OnEnable()
    {

        SouthBtn.onClick.AddListener(MyFunction);
    }

    void MyFunction()
    {
        GameText.text = BackText.text;
        DontDestroyOnLoad(GameText.gameObject);
    }
    */

}
