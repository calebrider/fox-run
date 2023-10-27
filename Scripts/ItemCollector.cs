using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int appleCount = 0;

    [SerializeField] private Text applesText;

    [SerializeField] private AudioSource collectSoundEffect;
    [SerializeField] private AudioSource finishSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {   
            collectSoundEffect.Play();
            Destroy(collision.gameObject);
            appleCount++;
            applesText.text = "Apples: " + appleCount;
        }

        if (collision.gameObject.CompareTag("Trophy"))
        {
            finishSoundEffect.Play();
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    private void OnDisable()
    {
        PlayerPrefs.SetInt("appleScore", appleCount);
    }
}
