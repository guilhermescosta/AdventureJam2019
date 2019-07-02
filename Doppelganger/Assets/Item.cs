using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    public string description;

    public string textFX;

    public bool isOver;
    public bool onBox;

    public Invetory _inventory;

    private void Start()
    {
       
        _inventory = GameObject.FindGameObjectWithTag("box").GetComponent<Invetory>();
    }

    private void Update()
    {
        if (onBox)
        {
           // Debug.Log("ok");
            CheckDouble();
        }
    }

    public void OnMouseOver()
    {
        GetComponent<BoxCollider2D>().isTrigger = false;
    }

    private void OnMouseExit()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

    private void OnMouseDown()
    {
        GameObject.FindGameObjectWithTag("gametext").GetComponent<TextEffect>().fullText = description;
        StartCoroutine(GameObject.FindGameObjectWithTag("gametext").GetComponent<TextEffect>().ShowText());
        
    }

    // Usei o on mouse drag para marcar um objeto (com boxcollider2d) e arrastar
    private void OnMouseDrag()
    {
        float distance = 10;  // eixo Z
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance); // guarda a posição do mouse
        Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos); // guarda a posição convertida do mouse em relação a camera 
        transform.position = objectPos;   // atualiza a posição pela posição convertida. 

    }

    // se soltar o botão do mouse com o item sobre a caixa do inventario, ele fica salvo na caixa. Se ele for arrastado para fora da caixa, ele é removido do vetor
    private void OnMouseUp()
    {
        if (onBox)
        {
            _inventory.items.Add(this.gameObject);
        }
        else {
            _inventory.items.Remove(this.gameObject);
        }
    }

    // verifica se o objeto esta sobre o trigger da caixa do inventario
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("box")) {
            onBox = true;
          
        }
    }

    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("box"))
        {
            onBox = false;
            
        }
    }


    // verifica se o objeto tem uma cópia. 
    void CheckDouble() {
        GameObject[] items = GameObject.FindGameObjectsWithTag("item");

        foreach (GameObject item in items)
        {
            if (!item.GetComponent<Item>().onBox && item.name == this.gameObject.name) {   
                Destroy(item);
            }
        }
    }




}
