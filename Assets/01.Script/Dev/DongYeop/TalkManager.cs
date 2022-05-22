using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour //NPC���� ���ϴ°� ��������. 
{
    Dictionary<int, string[]> TalkData;
    void Awake()
    {
        TalkData = new Dictionary<int, string[]>();
        GenerateData();
    }


    void GenerateData()
    {
        TalkData.Add(1000, new string[] { "�ݰ����ϴ�.", $"�̰��� �����ִ��� �ſ� ���� \n \t\t �̷��� �Դϴ�.", "�湮�� ȯ���մϴ�." });

        TalkData.Add(1001, new string[] { "����ü �������� �־����ɱ�?", "������ ��ο� ������ �ʵ� �׷��� ?" });

        TalkData.Add(1002, new string[] { "��- ��- �߸���-- -�̻�?" });

        TalkData.Add(1003, new string[] { "���� �ſ�ӿ� ���� �ʹ� ���ƿ�" });
    }

    public string GetTalk(int id, int talkIndex)
    {
        if (talkIndex == TalkData[id].Length)
            return null;
        else
            return TalkData[id][talkIndex];
    }
}
