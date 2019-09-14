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

    void OnEnable()
    {

        SouthBtn.onClick.AddListener(MyFunction);
    }

    void MyFunction()
    {
        GameText.text = BackText.text;
        DontDestroyOnLoad(GameText.gameObject);
    }

}
