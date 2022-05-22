using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteChanger : MonoBehaviour //Ư�� Ű�� �������� �̹����� �ٲ�°� ��������ϴ�
{
    public int curState;
    public Image image;
    public Sprite changer;
    bool isChange = true;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && isChange == true) //EscŰ �������� ������� �ʵ��� �ϴ°ſ��� 
        {
            isChange = false;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && isChange == false)
        {
            isChange = true;
        }
        
        if(Input.GetMouseButtonDown(0) && isChange == true)
        {
            Change();
        }
    }
    public void Change()
    {
        image.sprite = changer;
    }
}