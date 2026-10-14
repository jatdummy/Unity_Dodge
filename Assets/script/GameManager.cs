using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverText;
    public TextMeshProUGUI timeText;
    public TextMeshProUGUI recordText; 

    private bool isGameOver; 
    private float surviveTime;
    void Start()
    {
        isGameOver = false;
        surviveTime = 0f;
    }

    void Update()
    {
        if (!isGameOver)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }

    public void OnPlayerDead() 
    {
        isGameOver = true; 
        gameOverText.SetActive(true); 

        float bestTime = PlayerPrefs.GetFloat("BestTime");
        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }

        recordText.text = "Best Time : " + (int)bestTime;
    }
}
