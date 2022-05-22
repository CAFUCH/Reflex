using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour //Ư�� ��ġ���� Ư��Ű�� ������ ��ȣ�ۿ� �ϴ°� ��������ϴ�
{
    public NPCManager manager;

    Rigidbody2D rigid;
    Vector3 dirVec;
    float h;
    GameObject scanNPC2;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        bool hDown = Input.GetButtonDown("Horizontal");

        //Direction
        if (hDown && h == -1)
            dirVec = Vector3.left;
        else if (hDown && h == 1)
            dirVec = Vector3.right;

        //Scan NPC
        if (Input.GetKeyDown(KeyCode.F) && scanNPC2 != null)
            manager.Action(scanNPC2);
    }

    void FixedUpdate()
    {
        //ray 
        Debug.DrawRay(rigid.position, dirVec * 5f, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(rigid.position, dirVec, 5f, LayerMask.GetMask("NPC"));

        if (rayHit.collider != null) // rayhit �ȿ� NPC�� ������
        {
            scanNPC2 = rayHit.collider.gameObject;
        }
        else 
            scanNPC2 = null;
    }
}
