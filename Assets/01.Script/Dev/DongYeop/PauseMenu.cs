using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour // ESCŰ�� ������ ����â�� �߰Ը��� ��ũ��Ʈ
{
    public GameObject pauseMenuUI;
    [SerializeField]
    private AudioClip pauseSound;

    bool isToggled = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
            AudioPool.instance.Play(pauseSound);
        }
    }
    void Pause()
    {
        
        pauseMenuUI.SetActive(isToggled);
        if (isToggled)
        {
            GameManager.playerTimeScale = 0;
            Time.timeScale = 0;
            isToggled = false;
        }
        else
        {
            GameManager.playerTimeScale = 1;
            Time.timeScale = 1;
            isToggled = true;
        }
    }
}
