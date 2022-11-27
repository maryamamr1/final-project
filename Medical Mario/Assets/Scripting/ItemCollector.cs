using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int apples = 0;

    [SerializeField] private Text applesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            apples++;
            applesText.text = ("Apples: " + apples);
        }
    }
}

//Followed tutorial for this code using youtube.com/watch?v=pXn9icmreXE&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U