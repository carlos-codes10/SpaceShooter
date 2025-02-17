using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] GameObject gameOverUI;
    private PlayerLogic Player;
    private EnemySpawner enemySpawner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Time.timeScale = 1.0f;
        scoreText.text = "SCORE: 0";
        Player = FindAnyObjectByType<PlayerLogic>();
        enemySpawner = FindAnyObjectByType<EnemySpawner>();
    }

    int Score;
    public void ScoreAdder()
    {
        Score++;
        scoreText.text = "SCORE: " + Score;
    }

    public void GameOver()
    {
        gameOverUI.SetActive(true);
        Player.gameObject.SetActive(false);
        enemySpawner.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
