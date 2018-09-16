using UnityEngine;
using UnityEngine.SceneManagement; //Change to different scene


public class GameManager : MonoBehaviour {

    bool gameEnd = false;
    public float restartDelay = 1f; //Float number of restart delay
    public GameObject completeLevelUI;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void GameOver() //use public void to make it accessible (as defualt void is always private)
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            Debug.Log("GAME OVER!");
            Invoke("Restart", restartDelay); //To add delay
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
