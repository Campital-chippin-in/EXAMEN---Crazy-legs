using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Level_1");  // Aseg�rate de usar el nombre correcto de tu escena del juego
    }
}
