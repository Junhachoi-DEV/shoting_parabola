using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 자료출쳐 https://yoonstone-games.tistory.com/110


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
        start_pos = s1.position;
        end_pos = s2.position;

        // 두 지점의 중앙값
        Vector3 center = (start_pos + end_pos) * 0.5f;


        // 위로 그리기 위해서 아래로 중앙값을 내려준다.
        center.y -= 3;

        // 두지점을 내려간 중앙값 기준으로 수정
        start_pos = start_pos - center;
        end_pos = end_pos - center;

        for (int i = 0; i < line.positionCount; i++)
        {
            Vector3 point = Vector3.Slerp(start_pos, end_pos, i / (float)(line.positionCount - 1));

            point += center;
            line.SetPosition(i, point);
        }
        
        //transform.position = Vector3.Slerp(s1.position, s2.position, t);
    }
}
