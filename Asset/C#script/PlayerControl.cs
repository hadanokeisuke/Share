using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rigidBody;/*
    public GameObject player;
    public GameObject allow;
    public GameObject playerPrefab;
    public GameObject allowPrefab;*/
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 now = rigidBody.position;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //Input.GetKey(KeyCode.W)
        if (x > 0)
        {
            //rigidBody.AddForce(transform.right * 2.0f);
            now += new Vector3(0.05f, 0.0f);
            rigidBody.position = now;
        }
        else if (x < 0)
        {
            //rigidBody.AddForce(-transform.right * 2.0f);
            now += new Vector3(-0.05f, 0.0f);
            rigidBody.position = now;
        }
        if(y > 0)
        {
            rigidBody.AddForce(transform.up * 2.0f);
            now += new Vector3(0.0f, 0.05f);
            rigidBody.position = now;
        }
        else if (y < 0)
        {
            rigidBody.AddForce(-transform.up * 2.0f);
            now += new Vector3(0.0f, -0.05f);
            rigidBody.position = now;
        }
        
    }/*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            //other.gameObject.SetActive(false);
            //Destroy(allow);
            //Destroy(player);

            //allow = (GameObject)Instantiate(allowPrefab);
            //player = (GameObject)Instantiate(playerPrefab);
    /*
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.name);
        }
    }*/
    /*
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            Debug.Log("ÚG‚P");
            other.gameObject.SetActive(false);/*
            if (Input.GetKeyDown(KeyCode.N))                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
            {
                Debug.Log("ÚG3");
                other.gameObject.SetActive(false);
            }
        }
    }*/
    
    
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("ÚG‚Q");
    }/*
    void OnItemPickUp(InputValue input)
    {
        this.OnTriggerEnter2D();
    }*/

    //ƒ^ƒO"enemy"‚ÉÚG‚µ‚½‚ç‹­§ƒŠƒZƒbƒg
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == ("enemy")){
            Scene activeScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(activeScene.name);
        }
    }
}
