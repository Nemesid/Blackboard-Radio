using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStarter : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject gameOverPannel;

    private void Start()
    {
        Time.timeScale = 0;
    }
    
    public void StartButton()
    {
        MainMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void GameQuit()
    {
        Application.Quit();
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
