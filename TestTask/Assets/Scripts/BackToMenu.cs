using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
