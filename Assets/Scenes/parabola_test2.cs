using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola_test2 : MonoBehaviour
{

    public Vector2 mouse_direction;
    public GameObject allow;
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mouse_direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float r = Mathf.Atan2(mouse_direction.y, mouse_direction.x) * Mathf.Rad2Deg;
        allow.transform.rotation = Quaternion.Euler(0, 0, r + (-90));

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, allow.transform.position, allow.transform.rotation);
        }
            
    }
}
