using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pelota : MonoBehaviour
{
    public Vector2 velocidadInicial;
    private Rigidbody2D pelotitaRB;
    bool isMoving;
    public Score sumarScore;


    // Start is called before the first frame update
    void Start()
    {
        pelotitaRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMoving)
        {
            pelotitaRB.velocity = velocidadInicial;
            isMoving = true;
        }
        Level2();

    }
    private void OnCollisionEnter2D(Collision2D choque)
    {
        if (choque.gameObject.CompareTag("Brick"))
        {
            sumarScore.Contador(1);
            Destroy(choque.gameObject);
        }
        if (choque.gameObject.CompareTag("Killzone"))
        {
            Gameover();
        }
    }
    void Level2()
    {
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
        if (bricks.Length == 0)
        {
            SceneManager.LoadScene("Level2");
        }
    }

    void Gameover()
    {
        SceneManager.LoadScene("Gameover");
    }
}