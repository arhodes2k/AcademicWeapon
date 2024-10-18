using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [SerializeField] GameObject Aplus;
    [SerializeField] GameObject Bplus;
    [SerializeField] GameObject Cminus;
    float bound = 4.5f;
    float speed = 2f;
    bool goingUp;
    float waitTime;
    float waitCounter;
    float aTime;
    float bTime; 
    float cTime;
    float minATime = 50f;
    float minBTime = 4f; 
    float minCTime = 0.1f;
    float maxATime = 75f;
    float maxBTime = 8f;
    float maxCTime = 5f;
    public int score;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("aSpawn", minATime);
        Invoke("bSpawn", minBTime);
        Invoke("cSpawn", minCTime);
    }

    // Update is called once per frame
    void Update()
    {
      
        
     if (goingUp == true){ 
             transform.Translate(0f, speed * Time.deltaTime, 0);
        
            if (transform.position.y > bound){ 
                goingUp = false; 
              }
        } else {
            transform.Translate(0f, -speed * Time.deltaTime, 0);
        
            if (transform.position.y < -bound){ 
                goingUp = true; 
              }
        }
   
    }
    void aSpawn () {
        GameObject a;
        aTime = Random.Range(minATime, maxATime);
        a = Instantiate(Aplus);
        Invoke("aSpawn", aTime);
        a.transform.position = transform.position;
    }
    void bSpawn () {
        GameObject b;
        bTime = Random.Range(minBTime, maxBTime);
        b = Instantiate(Bplus);
        Invoke("bSpawn", bTime);
        b.transform.position = transform.position;
    }
    void cSpawn () {
        GameObject c;
        cTime = Random.Range(minCTime, maxCTime);
        c = Instantiate(Cminus);
        Invoke("cSpawn", cTime);
        c.transform.position = transform.position;
    }
}
