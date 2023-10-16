using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyBlue : MonoBehaviour

{
     float outOfBound = -5.5f;
    [SerializeField] private float speed = 2f;
    
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
