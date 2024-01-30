using UnityEngine;

public class ShowEndMenu : MonoBehaviour
{
    [SerializeField] GameObject _finishWindow;

    public void VisibleTrue()
    {
        _finishWindow.SetActive(true);
    }
}
