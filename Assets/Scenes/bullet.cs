 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rigid;
    parabola_test2 para;
    public float bullet_speed;
    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        para = FindObjectOfType<parabola_test2>();
        rigid.velocity = new Vector2(para.mouse_direction.x, para.mouse_direction.y) * bullet_speed;
    }
}
