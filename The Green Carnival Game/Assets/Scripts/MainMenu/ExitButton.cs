using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public void QuitGame()
    {
        // Quit the application (works in standalone builds)
        Application.Quit();
    }
}

