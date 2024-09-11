using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void Contador(int sumarPuntos)
    {
        score += sumarPuntos;
        ActualizarTexto();
    }

    void ActualizarTexto()
    {
        scoreText.text = "" + score;
    }
}