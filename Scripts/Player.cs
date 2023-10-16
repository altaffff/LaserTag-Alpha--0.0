using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] private float speed = 5f;
    public GameObject bullet;
    private float boundry = 8.35f;
    private float horizontalInput;
    
  
    void Update()
    {
        Prefab();
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * Time.deltaTime * speed * horizontalInput);
        if (transform.position.x > boundry)
        {
            transform.position = new Vector3(boundry, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -boundry)
        {
            transform.position = new Vector3(-boundry, transform.position.y, transform.position.z);
        }

        
        
    }
     void Prefab()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
          
            Instantiate(bullet, transform.position, transform.rotation);
        }

        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

    }
  }

