using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField] float bound = 3.75f;
    [SerializeField] float xpos = 0f;
    [SerializeField] GameObject Fireball;
    [SerializeField] Vector3 translation;
    Animator anim;
      bool fire = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
      
    }

    // Update is called once per frame
    void Update()
    {

        GameObject ball;
        
        float speed = 3f;
        float move = Input.GetAxis("Vertical");
        if(transform.position.y > bound){
            transform.position = new Vector3(xpos, bound, 0f);
        } else{ 
            transform.Translate(0f, move * speed * Time.deltaTime, 0f); 
            }
        if(transform.position.y < -bound){
            transform.position = new Vector3(xpos, -bound, 0f);
        } else{ 
            transform.Translate(0f, move * speed * Time.deltaTime, 0f);
            }
        if(Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.Log("deex");
            ball = Instantiate(Fireball);
            ball.transform.position = transform.position + translation;
            fire = true;
        } else {
            fire = false;
        }
        if (fire == true) {
            anim.SetBool("Click", true);
            } else {
            anim.SetBool("Click", false);
        }
            
    }
}
