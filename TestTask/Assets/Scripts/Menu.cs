using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject selectMode;
    [SerializeField] GameObject settingsMenu;
    [SerializeField] GameObject policyMenu;
 
    public void Play()
    {
        mainMenu.SetActive(false);
        selectMode.SetActive(true);
    }

    public void HowToPlay()
    {

    }

    public void OpenSettings()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void OpenPolicy()
    {
        mainMenu.SetActive(false);
        policyMenu.SetActive(true);
    }

    public void Exit()
    {

    }

    public void CloseSelectMode()
    {
        selectMode.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void ClosePolicy()
    {
        policyMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
