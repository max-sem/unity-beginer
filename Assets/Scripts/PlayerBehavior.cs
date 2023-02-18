using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // 1
    public float moveSpeed = 10f;
    public float rotateSpeed = 75f;
    // 2
    private float vInput;
    private float hInput;

    void Update()
    {
        // 3 ����� ��������� ������������ ��� (-1 0 1) � �������� �� ��������
        // ��� - ��� Axes �� ������� ����� (W-S), � �� ������ �����������!!!
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        
        // 4 ����� �������������� �������� !!! (-1 0 1) � �������� �� ��������
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;

        Debug.Log($"vInput: {vInput}, hInput: {hInput}");

        // 5 Translate ���������� ������������ ���������� !(������������ ����� ��������� ��� Z)
        //  Vector3.forward = Vector3(0, 0, 1)	- ���������������� ������ �� Z
        this.transform.Translate(Vector3.forward * vInput * Time.deltaTime);

        // 6
        // Vector3.up = Vector3(0, 1, 0) �������� ���������� ������ ��������� ���
        // ��� �� Translate ��� Vector3.up, �� ������� ��
        this.transform.Rotate(Vector3.up * hInput * Time.deltaTime);
    }
}
