using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) //�� ������ ��� ����� ���� ��� �� Instane ��� �������
        {
            Instance = this; // ���� Instane ��� current Instance
            DontDestroyOnLoad(gameObject); //�� ����������� ���� �� ������� 
        }
        else
        {
            Destroy(gameObject); //�� ������� Instance �� ����spawn����� ��� ���� Instance ���� ���� �� ������ ���� ���
        }

    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
