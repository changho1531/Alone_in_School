using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// �ۼ��� :   2023-08-13 �Ͽ���
/// �ۼ��� :   ������ �ۼ�
/// 
/// ==����==
/// StartScene, BeforeScene, MainScene, EndScene ���� MainCamera�� ������ ��ũ��Ʈ
/// �ʿ信 ���� BlackOut ȿ���� ���ų� ������ StartScene OR BeforeScene���� �̵� �� �����Ų�� 
/// </summary>

public class HA_Effects : MonoBehaviour
{
    public GameObject blackCubes;   // BlackOut ȿ���� ���� ��ġ�� ���� ť����� �Ҵ��ϴ� ����

    private void Update()   // �ش� �κ��� ���ǰ� �ʿ�, ���� ��� ������ �ش� Ű�� ������ ������ ����ǰų� ���� �̵���, ������ �� ������ �Ǽ��� ���� ���ɼ��� ����
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("BeforeScene");
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("EndScene");
        }
    }

    public void GoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void GoStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void BlackOutOn()
    {
        blackCubes.SetActive(true);
    }

    public void BlackOutOff()
    {
        blackCubes.SetActive(false);
    }
}
