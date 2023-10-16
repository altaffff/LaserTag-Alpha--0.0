using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawn : MonoBehaviour
{
                                                                                                                    
    public GameObject []game;
    private float location = 7.35f;
    private float defaultY = 4.52f;
   

    private void Start()
    {
        InvokeRepeating("Spawn",3f,2f);
    }
 
 
    private void Spawn()
    {
        
        int randomObj = Random.Range(0, game.Length);
        float Randospa = Random.Range(location, -location);
        Vector3 Randopos = new Vector3(Randospa, defaultY, transform.position.z);
        Instantiate(game[randomObj], Randopos, game[randomObj].transform.rotation);
    }

}
