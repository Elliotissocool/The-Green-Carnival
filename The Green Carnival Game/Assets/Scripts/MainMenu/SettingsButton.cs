using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public void Settings()
    {
        // Load your game scene
        SceneManager.LoadScene("Settings"); // Replace "GameScene" with your actual game scene name
    }
}

