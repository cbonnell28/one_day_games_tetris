using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnTetromino : MonoBehaviour
{
    private int score;
    public GameObject [] Tetrominoes;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        NewTetromino();
        score = 0;
        SetScoreText();
    }

    // Update is called once per frame
    public void NewTetromino()
    {
        Instantiate(Tetrominoes[Random.Range(0, Tetrominoes.Length)], transform.position, Quaternion.identity);
    }

    public void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void UpdateScore()
    {
        score += 100;
    }
}
