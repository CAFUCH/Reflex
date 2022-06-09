using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_NaEun : MonoBehaviour
{
    #region �߻� ����
    [Header("�߻� ����")]
    [SerializeField] protected float fireDelay;
    [SerializeField] protected GameObject bullet;
    [SerializeField] protected Transform firePosition;
    [Range(1f, 10f)] [SerializeField] protected float time = 1f;
    #endregion

    #region �ͷ� ����
    [Header("�ͷ� ����")]
    [SerializeField] protected int maxCharge;
    protected int curCharge;
    #endregion

    #region �ִϸ��̼�
    protected Animator turretAnim;
    #endregion

    private void Awake()
    {
        //StartCoroutine(TurretShooting());
        turretAnim = GetComponent<Animator>();
        ChildAwake();
    }

    protected virtual void ChildAwake()
    {

    }

    /// <summary>
    /// �Ѿ� �߻� �Լ�
    /// </summary>
    protected virtual void Shoot()
    {
        Instantiate(bullet, firePosition.position, firePosition.rotation);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {

    }

    /// <summary>
    /// �ͷ� �۵� �Լ�
    /// </summary>
    /// <param name="time"></param> �۵� �ð�
    /// <returns></returns>
    protected virtual IEnumerator Use(float time)
    {
        yield return new WaitForSeconds(time);
        turretAnim.SetTrigger("Off");
    }
}
