using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UseItem : MonoBehaviour
{
    public GameObject itemNeed;
    public Sprite _newSprite;
    public SpriteRenderer _sprite;

    public GameObject hiddenItem;

    public TextEffect _text;
    public bool creatureDown;
    public GameObject doppelganger;

    public GameObject itemBox;


    // Start is called before the first frame update
    void Start()
    {
        creatureDown = false;
        _text = GameObject.FindGameObjectWithTag("gametext").GetComponent<TextEffect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (creatureDown && Input.GetKey(KeyCode.Escape)) {
            itemBox =  GameObject.FindGameObjectWithTag("box");
            Destroy(itemBox);

            GameObject[] items = GameObject.FindGameObjectsWithTag("item");
            foreach (GameObject item in items)
                GameObject.Destroy(item);

            SceneManager.LoadScene(10);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entrou no trigger");
        if (collision.name == itemNeed.name) {
            if (itemNeed.name == "Flashlight")
                useFlashLight();
            else if (itemNeed.name == "Chave-Key")
                useKey();
            else if (itemNeed.name == "gun")
                useGun();
        } 
    }

    public void useFlashLight() {
        _sprite.sprite = _newSprite;
        hiddenItem.SetActive(true);
        Destroy(this.gameObject);
    }

    public void useKey() {
        hiddenItem.SetActive(true);
        Destroy(this.gameObject);

    }

    public void useGun() {
        Debug.Log("usou arma");
       // Destroy(this.gameObject);
        Destroy(doppelganger);
        _text.fullText = "the shadow figure just vanished !\nYou must find the creature and end this nightmare.\nPress esc to finish.";
        StartCoroutine(_text.ShowText());
        creatureDown = true;
    }
}
