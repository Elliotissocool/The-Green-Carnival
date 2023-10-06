using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsButton : MonoBehaviour
{
    public void Settings()
    {
        // Load your game scene
        SceneManager.LoadScene("Lvl_Settings"); // Replace "GameScene" with your actual game scene name
    }
}

