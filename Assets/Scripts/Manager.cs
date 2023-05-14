using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public void Repeat()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Game()
    {
        SceneManager.LoadScene(1);
    }
    public void About()
    {
        SceneManager.LoadScene(2);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
