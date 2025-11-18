using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public string gameSceneName = "Game"; // nom exact de ta scène de jeu

    public void PlayGame()
    {
        // Charge la scène de jeu par son nom (recommandé avec Build Profiles)
        SceneManager.LoadScene(gameSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitter le jeu");
    }
}
