using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    //These Are Variables
    public static PlayerMovement instance;
    
    [SerializeField] float yVal = 0f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] int health;
    [SerializeField] int healthMax;
    [SerializeField] int coin;

    public string level;
    public bool winning;
    public GameObject player;

    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        respawnPoint = transform.position;
        health = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        //if (level == "Congrats")
        //{
            //winning = true;
            //CONGRATS.instance.gameObject.SetActive(true);
            //Destroy(player);
        //}
    }


    private void OnCollisionEnter(Collision other)
    {
        if(other.collider.tag == "Hit")
        {
            health -= 1;
            transform.position = respawnPoint;
            Debug.Log("HITTED");
            if(health <= 0)
            {
                DeathScreen.instance.deathScreen.SetActive(true);
                Destroy(player);
            }
        }

        if(other.collider.tag == "Coin")
        {
            coin += 1;
        }

        if(other.collider.tag == "Finish")
        {
            SceneManager.LoadScene(level);
        }

        
    }

    void MovePlayer()
    {
        float xVal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zVal = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.position = new Vector3(transform.position.x + xVal, transform.position.y + yVal, transform.position.z + zVal);
    }
}
