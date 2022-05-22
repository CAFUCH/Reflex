using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeEffect : MonoBehaviour //��� �ִϸ��̼� ��ũ��Ʈ �Դϴ�.
{
    string targetMsg;
    public float CharPerSeconds;
    [SerializeField] TextMesh msgText;
    int index;

    private void Awake()
    {
        msgText = GetComponent<TextMesh>();
    }

    public void Setmsg(string msg)
    {
        targetMsg = msg;
        EffectStart();
    }

    void EffectStart()
    {
        if(msgText == null)
            msgText = GetComponent<TextMesh>();
        msgText.text = " ";
        index = 0;

        Invoke("Effecting", 1f/CharPerSeconds);
    }

    void Effecting()
    {
        if(msgText.text.Trim() == targetMsg.Trim())
        {
            return;
        }

        msgText.text += targetMsg[index];
        index++;
        Invoke("Effecting", 1 / CharPerSeconds);
    }
}
