using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    int dir =1;

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }

    public void ChangeDirection () {
        dir *=-1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2 (0, 12 * dir);
    }

    void OnTriggerEnter2D(Collider2D col) {

        if (dir==1){
            if (col.gameObject.tag=="Enemy"){
                col.gameObject.GetComponent<Enemy>().Damage();
                Destroy(gameObject);
            }
        } else {
            if (col.gameObject.tag=="Player") {
                col.gameObject.GetComponent<PlayerControll>().Damage();
                Destroy(gameObject);
            }
        }
    }
}
