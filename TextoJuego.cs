using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextoJuego : MonoBehaviour
{
    public Text texto;
    private string[] textos = {
        "Hola, en un futuro distópico...",
        "Texto 2 cuando se presiona espacio...",
        "Texto 3 cuando se presiona espacio..."
    };
    private int currentIndex = 0;
    private bool mostrandoTexto = false;

    private void Start()
    {
        StartCoroutine(Reloj());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !mostrandoTexto)
        {
            mostrandoTexto = true;
            NextText();
        }
    }

    private IEnumerator Reloj()
    {
        foreach (char caracter in textos[currentIndex])
        {
            texto.text += caracter;
            yield return new WaitForSeconds(0.1f);
        }
        mostrandoTexto = false;
    }

    private void NextText()
    {
        currentIndex++;
        if (currentIndex < textos.Length)
        {
            texto.text = "";
            StartCoroutine(Reloj());
        }
        else
        {
            texto.text = "Fin de los textos";
        }
    }
}
