using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void Endgame()
    {
        if(gamehasEnded==false)
        {
            gamehasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}