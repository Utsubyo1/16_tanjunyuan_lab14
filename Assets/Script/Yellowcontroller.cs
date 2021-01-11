using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yellowcontroller : MonoBehaviour
{
    public GameObject YellowText;
    private int YellowCounter;

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
            YellowCounter++;

            YellowText.GetComponent<Text>().text = "Red: " + YellowCounter;

            audioSource.Play();
        }
    }
}
