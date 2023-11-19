using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetDestroy : MonoBehaviour
{

    private GameObject player;
    public AudioSource musicSound;

    // Start is called before the first frame update
    void Start()
    {
        musicSound = GetComponent<AudioSource>();

        player = GameObject.FindGameObjectWithTag("Player");
    }

private void OnTriggerEnter2D(Collider2D collision)
{
    if(collision.tag == "Border")
    {
        Destroy(this.gameObject);
    }

    else if(collision.tag == "Player")

    {
        musicSound.Play();
        Destroy(player.gameObject);
    }
}
}
