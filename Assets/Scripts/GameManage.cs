using UnityEngine;
using TMPro;

public class GameManage : MonoBehaviour
{
    float timer = 120;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI scoreText;
    public static float score = -1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

        timer -= Time.deltaTime;
        timerText.text = "Time: " + Mathf.FloorToInt(timer).ToString();

        if(timer <= 1)
        {
            Time.timeScale = 0f;
            gameOverText.text = "Game over! You completed " + score + " deliveries!";
            gameOverText.gameObject.SetActive(true);
            
        }
    }
}
