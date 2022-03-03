using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    void Awake()
    {
        if(instance==null)
        {
            instance = null;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public static GameManager Instance
    {

        get
        {
            if (instance is null)
                Debug.LogError("Game Manager is NULL");

            return instance;
        }
    }
   
    


    public void ChangeSceneSelectChapter(int number)
    {
        SceneManager.LoadScene(1);
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
