using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogFollow : MonoBehaviour /* �÷��̾ ������� ��ǳ���� ��������ϴ�. �ٵ� ���� ���� �����ϴ�.*/
{
    public GameObject predialog;
    public GameObject canvas;
    [SerializeField] private Transform trans;
    //[SerializeField] private RectTransform dialog;
    public float height = 1.7f;

    void Start()
    {
        // = Instantiate(predialog, canvas.transform).GetComponent<RectTransform>();
    }

    void Update()
    {
        //Vector3 _dialogPos =  Camera.main.WorldToScreenPoint(new Vector3(transform.position.x, transform.position.y + height, 0));
        //dialog.position = _dialogPos;
    }
    public void SetPos(Vector3 worldPos)
    {
        trans.position = worldPos;
    }
}
