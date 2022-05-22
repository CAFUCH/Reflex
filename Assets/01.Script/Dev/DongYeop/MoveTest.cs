using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour // �÷��̾� �����ε� ESC�������� �� �����̵��� �߽��ϴ�. 
{
    public NPCManager manager;

    public float speed = 5f;
    bool isChange = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && isChange == true)
        {
            isChange = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isChange == false)
        {
            isChange = true;
        }

        if (isChange == true)
        {
            Move();
        }
    }

    void Move()
    {
        float h = manager.isAction ? 0 : Input.GetAxis("Horizontal");
        float v = manager.isAction ? 0 : Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, v, 0);
        transform.Translate(dir * speed * Time.deltaTime);
    }
}
