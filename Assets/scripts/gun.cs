using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletprf;
    public Transform firepoint;
    public float velocity=20f;
    // Start is called before the first frame update
    public void fire()
    {
        GameObject bullet = Instantiate(bulletprf, firepoint.position, firepoint.rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firepoint.up * velocity, ForceMode2D.Impulse);
    }
}
