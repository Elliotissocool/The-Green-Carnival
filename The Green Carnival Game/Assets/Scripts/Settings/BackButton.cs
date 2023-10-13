
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void Return()
    {
        // Load your game scene
        SceneManager.LoadScene("Lvl_MainMenu"); // Replace "GameScene" with your actual game scene name
    }
}