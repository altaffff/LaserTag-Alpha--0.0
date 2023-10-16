using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRed : MonoBehaviour

{
  
    float outOfBound = -5.5f;
    [SerializeField] private float speed = 2.5f;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

    }

    private void Update()
    {
        transform.Translate(Vector2.down*Time.deltaTime*speed);
        
        if (transform.position.y < outOfBound)
        {
            Destroy(gameObject);
        }
    }
}