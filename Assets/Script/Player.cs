using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public int count;
    public Text counttext;
    public GameObject gameOverPanel;
    private GameObject player;
    public AudioSource musicSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count=1;
        counttext.text = "1";
        player = GameObject.FindGameObjectWithTag("Player");
        musicSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        if(count <=0){
            gameOverPanel.SetActive(true);
            counttext.text = "DEAD!" ;
        }
    }
public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void FixedUpdate()
    {
rb.velocity = new Vector2(0,playerDirection.y * playerSpeed);
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(count <=0)
        {
            
            Destroy(player.gameObject);
            
        }

         else if(target.gameObject.CompareTag("Food"))
        {
            musicSound.Play();
            Destroy(target.gameObject);
            count=count+1;
            Health();
        }

        else if(target.gameObject.CompareTag("Crab"))
        {
            musicSound.Play();
            count=count-1;
           Health();
        }

        else if(target.gameObject.CompareTag("Rock"))
        {
            musicSound.Play();
            count=count-1;
            Health();
        }

        else if(target.gameObject.CompareTag("Fish3"))
        {
           musicSound.Play();
            count=count-2;
            Health();
        }

        else if(target.gameObject.CompareTag("Fish4"))
        {
            musicSound.Play();
            count=count-2;
            Health();
        }

        else if(target.gameObject.CompareTag("Fish5"))
        {
            musicSound.Play();
            count=count-2;
            Health();
        }

        else if(target.gameObject.CompareTag("Fish6"))
        {
            musicSound.Play();
            count=count-2;
            Health();
        }
        
    }

    void Health()
    {
counttext.text =  count.ToString();

    }
}
