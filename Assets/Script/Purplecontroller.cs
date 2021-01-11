using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Purplecontroller : MonoBehaviour
{
    public GameObject PurpleText;
    private int PurpleCounter;

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
            PurpleCounter++;

            PurpleText.GetComponent<Text>().text = "Red: " + PurpleCounter;

            audioSource.Play();
        }
    }
}
