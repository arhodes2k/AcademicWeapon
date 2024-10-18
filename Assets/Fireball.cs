using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    float speed = 6f; 
    [SerializeField] float lifeTime = 2f;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);

    }
    void OnTriggerEnter2D (Collider2D collision){
        if(collision.tag == "GOOD" || collision.tag == "GREAT" ||collision.tag == "BAD"){
            Destroy(gameObject, 0.8f);
            animator.SetBool("hit", true);
            speed = 0f;
        }
    }
}
