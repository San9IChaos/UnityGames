using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [SerializeField] GameObject soundOn;
    [SerializeField] GameObject soundOff;
    [SerializeField] GameObject vibroOn;
    [SerializeField] GameObject vibroOff;

    public void EnabledSound()
    {
        soundOn.SetActive(true);
        soundOff.SetActive(false);
    }

    public void DisabledSound()
    {
        soundOn.SetActive(false);
        soundOff.SetActive(true);
    }

    public void EnabledVibration()
    {
        vibroOff.SetActive(false);
        vibroOn.SetActive(true);
    }

    public void DisabledVibration()
    {
        vibroOff.SetActive(true);
        vibroOn.SetActive(false);
    }
}
