using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Redcontroller : MonoBehaviour
{
    public GameObject RedText;
    private int RedCounter;

    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            RedCounter++;

            RedText.GetComponent<Text>().text = "Red: " + RedCounter;

            audioSource.Play();
        }
    }
}
