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
    private void FixedUpdate()
    {
        
        rb = this.GetComponent<Rigidbody2D>();
        
        
        
        Debug.Log(player.position);
        
        rb.position = Vector3.MoveTowards(transform.position,player.position, speed);
        transform.rotation = Quaternion.Euler(Vector3.zero);
    }


}
