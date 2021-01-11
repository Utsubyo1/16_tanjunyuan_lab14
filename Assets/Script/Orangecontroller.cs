using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orangecontroller : MonoBehaviour
{
    public GameObject OrangeText;
    private int OrangeCounter;

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
            OrangeCounter++;

            OrangeText.GetComponent<Text>().text = "Red: " + OrangeCounter;

            audioSource.Play();
        }
    }
}
