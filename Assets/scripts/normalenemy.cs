using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalenemy : MonoBehaviour
{
    // S
    // tart is called before the first frame update

    public float speed=5f;
    public Transform player;
    Rigidbody2D rb;
    GameObject players;
    public gamemanager gm;
    public int enemyhealth;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        enemyhealth = 100;
    }
    private void FixedUpdate()
    {
        
       
        this.transform.rotation = Quaternion.Euler(new Vector3(0,0,0));


        //Debug.Log(player.position);
        
        transform.position = Vector3.MoveTowards(transform.position,player.position, speed);
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        if (collision.gameObject.tag=="bullet")
        {
            enemyhealth -= gm.bulletdamage;

        }
        if (enemyhealth<=0)
        {
            Destroy(this.gameObject);
        }

    }

}
