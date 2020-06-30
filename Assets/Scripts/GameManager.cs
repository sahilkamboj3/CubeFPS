using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public float restartDelay = 1f;
    bool gameHasEnded = false;
    public string highScoreName;

    void Update()
    {
        if (player.position.y < -1)
        {
            EndGame();
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            CheckScore(highScoreName);
            SceneManager.LoadScene("MainScreen");
        }
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            CheckScore(highScoreName);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void CheckScore(string highScoreName)
    {

        Scorer scorer = FindObjectOfType<Scorer>();

        Debug.Log(PlayerPrefs.GetInt(highScoreName));
        Debug.Log(scorer.score);
        Debug.Log(scorer.score > PlayerPrefs.GetInt(highScoreName));

        if ((int)scorer.score > PlayerPrefs.GetInt(highScoreName))
        {
            PlayerPrefs.SetInt(highScoreName, (int) scorer.score);
        }
    }

}
