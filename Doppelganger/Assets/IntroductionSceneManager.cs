using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroductionSceneManager : MonoBehaviour
{
    public GameObject TextObj;
    public float TmStart;
    public float TmLen = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

     // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }

        if (Time.time > TmStart + TmLen)
        {

            TextObj.SetActive(true);
        }
    }


}
