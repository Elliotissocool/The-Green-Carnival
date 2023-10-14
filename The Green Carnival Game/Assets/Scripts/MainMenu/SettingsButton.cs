using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{
    public void Credits()
    {
        // Load your game scene
        SceneManager.LoadScene("Lvl_Credits"); // Replace "GameScene" with your actual game scene name
    }
}

