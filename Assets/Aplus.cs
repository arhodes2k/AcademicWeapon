using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aplus : MonoBehaviour
{
    float move;
    float speed = -2f;
    float bound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        move = Random.Range(1.5f, 3f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * speed * Time.deltaTime, 0f, 0f);
        if(transform.position.x < bound){
            Destroy(gameObject);
        } 
    }
    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            Destroy(gameObject);
        }
        if(collision.tag == "fire"){
            Destroy(gameObject);
        }
    }
}
