using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] private Toggle toggle;
    [SerializeField] private Sprite soundIcon;
    [SerializeField] private Sprite muteIcon;

    private void Start()
    {
        if (AudioListener.volume == 0)
        {
            toggle.isOn = true;
        }
        else
        {
            toggle.isOn = false;
        }
    }

    private void Update()
    {
        if (toggle.isOn)
        {
            toggle.image.sprite = muteIcon;
            AudioListener.volume = 0;
        }
        else
        {
            toggle.image.sprite = soundIcon;
            AudioListener.volume = 1;
        }
    }

    // Silences application when navigating away
    private void OnApplicationFocus(bool isFocused)
    {
        Silence(!isFocused);
    }

    private void OnApplicationPause(bool isPaused)
    {
        Silence(isPaused);
    }

    private void Silence(bool silence)
    {
        AudioListener.volume = silence ? 0 : 1;
    }

}
