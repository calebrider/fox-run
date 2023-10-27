using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private AudioSource clickSoundEffect;

    public void Quit()
    {
        clickSoundEffect.Play();
        SceneManager.LoadScene(0);
    }
}
