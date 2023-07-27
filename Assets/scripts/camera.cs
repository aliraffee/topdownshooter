using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{

    public Transform player;
    Vector3 buffer = new Vector3(0f, 0f, -10f);
    public float smoothness = 0.25f;
    Vector3 velo = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = player.position + buffer;
        this.transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, smoothness);
    }
}
