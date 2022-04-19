using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject left, right;
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    int health = 3;

    Vector2 movement;

    public GameObject bullet;

    int delay = 0;
    
    void Awake() {
        left = transform.Find("left").gameObject;
        right = transform.Find("right").gameObject;
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if(Input.GetKey(KeyCode.Space) && delay > 70)
            Shoot();

        delay ++;

    }

    void FixedUpdate() {
        //Movement
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void Damage() {
        health--;
            if(health==0)
                Destroy(gameObject);
    }
    
    void Shoot(){
        delay = 0;
        Instantiate(bullet, left.transform.position, Quaternion.identity);
        Instantiate(bullet, right.transform.position, Quaternion.identity);
    }
}
