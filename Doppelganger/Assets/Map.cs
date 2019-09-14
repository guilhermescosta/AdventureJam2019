using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Map : MonoBehaviour
{
    public int _nextScene;
    public Invetory _inventory;

    public GameObject[] items;

    public ChangeScene _change;

    private void Awake()
    {
        _change = GameObject.FindGameObjectWithTag("box").GetComponent<ChangeScene>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _inventory = GameObject.FindGameObjectWithTag("box").GetComponent<Invetory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // muda cena. Verifica se o item está dentro do inventario, se ele estiver será mantido no jogo, caso contrário será destruído
    public void ChangeScene() {

        items = GameObject.FindGameObjectsWithTag("item");

        foreach (GameObject item in items) {
            if (item.GetComponent<Item>().onBox == true) {
                DontDestroyOnLoad(item);
            }
        }
        _change.lastScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(_nextScene);

    }
}
