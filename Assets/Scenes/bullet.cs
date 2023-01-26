 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rigid;
    public float bullet_speed;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        rigid.velocity = transform.position * bullet_speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
