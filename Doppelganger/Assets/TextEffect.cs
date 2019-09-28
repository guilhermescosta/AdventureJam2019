/*
Essa classe é estética. 
Serve para gerar efeito de maquina de escrever, uma letra aparece por vez na área de texto
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
    public float delay = 0.01f;
    public string fullText;
    public string currentText="";
    public bool endText;

    private void Start()
    {
        StartCoroutine(ShowText());
    }

    private void Update()
    {
       
    }
  
    //aqui é uma corotina, funciona como um método, mas quando é chamado ele tem prioridade na execução. O ciclo dela sempre termina com Yield
    public IEnumerator ShowText() { 
        for (int i=0; i<= fullText.Length; i++) {  // pra cada letra da frase, uma execução
             currentText = fullText.Substring(0, i);         // o texto é quebrado por letras
             this.GetComponent<Text>().text = currentText;     // joga uma letra por vez na área de texto
             yield return new WaitForSeconds(delay);  // Espera 0.1 segundos (valor da variavel delay) para executar o for novamente
            if (i == fullText.Length) {
              //  endText = true;
            }
        }
     
    }
    
}
