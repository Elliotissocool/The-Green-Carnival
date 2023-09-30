using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void PlayGame()
    {
        // Load your game scene
        SceneManager.LoadScene("TestScene"); // Replace "GameScene" with your actual game scene name
    }
}
