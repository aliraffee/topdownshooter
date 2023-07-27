using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// game idea
/// make enemy waves. increase evry time.
/// make spike shoot out of columns AND rows
/// xp upgrade 
/// aim with mouse. always shooting
/// upgrade dmg, move, firerate,health
/// infinte ammo 
/// drop health, cod zombie nuke. 
/// </summary>
public class gamemanager : MonoBehaviour
{
    public Transform player;
    public int speed,i,firerate, enemydamage,bulletdamage;
    public gun weapon;
    public Rigidbody2D rb;
    Vector2 mvdir, mousepos;
    public int health = 100;
    public TextMeshProUGUI healthtxt;
       
   

   
    // Start is called before the first frame update
    void Start()
    {
        bulletdamage = 30;
    }
    public void Update()
    {
        playerMove();
        float movex = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");
        mvdir = new Vector2(movex, movey).normalized;
        mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void playerMove()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.position = new Vector2(player.position.x, player.position.y + speed);
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            player.position = new Vector2(player.position.x, player.position.y - speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.position = new Vector2(player.position.x - speed, player.position.y);


        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            player.position = new Vector2(player.position.x + speed, player.position.y);
        }
       // Debug.Log(player.position);
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("yes");
        if (collision.gameObject.name=="normal")
        {
            enemydamage = 30;
        }
        health -= enemydamage;
        enemydamage = 0;
        Debug.Log(collision.gameObject.name);
        healthtxt.text = health.ToString();
      
    }

    // Update is called once per frame
    private void FixedUpdate()
    
        
    
    {
        i++;
       

        if (i>firerate)
        {
            i = 0;
            weapon.fire();
        }
       // rb.velocity = new Vector2(mvdir.x * speed, mvdir.y * speed);
        Vector2 aimdir = mousepos - rb.position;
        float aimangel = Mathf.Atan2(aimdir.y, aimdir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimangel;
     
    }
   
}