using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola_test4 : MonoBehaviour
{
    public Transform s1, s2;

    Vector3 start_pos, end_pos;

    LineRenderer line;

    [Range(0, 1)]
    public float t;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void Update()
    {

        for (int i = 0; i < line.positionCount; i++)
        {
            Vector3 point = Vector3.Slerp(s1.position, s2.position, i / (float)(line.positionCount - 1));
            line.SetPosition(i, point);
        }
        
        //transform.position = Vector3.Slerp(s1.position, s2.position, t);
    }
}
