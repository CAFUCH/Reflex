using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    #region ��Ż
    [SerializeField] protected GameObject ptEnt;
    [SerializeField] protected GameObject ptQui;
    #endregion

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obe"))
        {
            ptEnt = collision.gameObject;
        }
    }

    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Obe"))
        {
            StartCoroutine(Teleport());
        }
    }

    /// <summary>
    /// ���� �̵� �Լ�
    /// </summary>
    /// <returns></returns>
    protected IEnumerator Teleport()
    {
        yield return null;
        ptEnt.transform.position = ptQui.transform.position;
    }
}
