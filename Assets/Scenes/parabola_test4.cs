using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// �ڷ����� https://yoonstone-games.tistory.com/110


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

        // �� ������ �߾Ӱ�
        Vector3 center = (start_pos + end_pos) * 0.5f;


        // ���� �׸��� ���ؼ� �Ʒ��� �߾Ӱ��� �����ش�.
        center.y -= 3;

        // �������� ������ �߾Ӱ� �������� ����
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
