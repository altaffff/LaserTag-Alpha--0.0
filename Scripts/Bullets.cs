using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private float outOfBound = 6f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.y > outOfBound)
        {
            Destroy(gameObject);
        }
    }
}