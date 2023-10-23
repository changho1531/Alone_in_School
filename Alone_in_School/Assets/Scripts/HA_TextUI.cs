using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class HA_TextUI : MonoBehaviour
{
    public GameObject linesObject;  // �ؽ�Ʈ�� ����� ���� ������Ʈ �Ҵ�
    private TextMesh lines;         // �ؽ�Ʈ�� ����� ���� ������Ʈ���� �ʿ��� ������Ʈ �Ҵ��ϴ� �뵵

    private string[] diglogue;      // ����� �ڸ��� ������ �����ϴ� �迭

    // ����ϴ� �ڸ��� ������ �����ϴ� �迭�� �ε����� �����ϴ� ����
    // �̺�Ʈ���� ������ �޸��ؾ� �� �� *�ٸ� �޼ҵ忡�� �Ȱ��� ������ ����� ���, �ʱ�ȭ ��ġ�� �ָ���, �޼ҵ� ó���� �ʱ�ȭ�� �ϸ� ȣ���� ������ 0���� �ʱ�ȭ �Ǳ� ������ �ε��� ���� �ȵ�*
    private int countEvent0 = 0;
    private int countEvent4 = 0;

    private void Start()
    {
        lines = linesObject.GetComponent<TextMesh>(); // �ؽ�Ʈ ������Ʈ�� TextMesh ������Ʈ�� ã�Ƽ� �Ҵ���
    }

    public void TextEvent0()
    {
        diglogue = new string[] { "...������", "�� �� �ڰ� ������", "�������� �ð��� �������� �� �ں���...", "(å�� ����� ���� �ܴ�)" };
        lines.text = diglogue[countEvent0];

        Color color = lines.color;
        color.a = 255f;
        lines.color = color;

        countEvent0++;
    }

    public void LineOff()   // �ش� �޼ҵ带 �̿��� �ڸ��� �����ϰ� ���� *�ڸ��� Ȱ��ȭ ���θ� ������ �����ϰ� ���� ��� ����ϼ���*
    {
        Color color = lines.color;
        color.a = 0f;
        lines.color = color;
    }
}
