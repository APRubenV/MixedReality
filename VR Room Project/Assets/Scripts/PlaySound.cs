using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource brick;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Desk")
        {
            brick.Play();
            Debug.Log("Nurrrr");
        }
    }
    public void playMusic()
    {
        brick.Play();
    }
}
