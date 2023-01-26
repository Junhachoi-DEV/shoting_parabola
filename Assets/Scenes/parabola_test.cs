using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 자료 출쳐 = https://www.youtube.com/watch?v=YvdiNsuJAKc
public class parabola_test : MonoBehaviour
{
    public float deg;
    public float turret_speed;
    public GameObject turret;
    public GameObject bullet;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            deg = deg + Time.deltaTime * turret_speed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            turret.transform.eulerAngles = new Vector3(0, 0, deg);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            deg = deg - Time.deltaTime * turret_speed;
            float rad = deg * Mathf.Deg2Rad;
            turret.transform.localPosition = new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
            turret.transform.eulerAngles = new Vector3(0, 0, deg);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject go =Instantiate(bullet);
            go.transform.position = turret.transform.position;
        }
    }
}
