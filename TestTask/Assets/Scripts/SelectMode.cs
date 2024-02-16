using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMode : MonoBehaviour
{
    public void OpenSquareLevel()
    {
        SceneManager.LoadScene("Square");
    }

    public void OpenCircleLevel()
    {
        SceneManager.LoadScene("Circle");
    }

    public void OpenDiamondLevel()
    {
        SceneManager.LoadScene("Diamond");
    }
}
