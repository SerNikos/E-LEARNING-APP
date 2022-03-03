using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null) //αν Τρέχει για πρώτη φορά και το Instane δεν υπάρχει
        {
            Instance = this; // Κάνε Instane την current Instance
            DontDestroyOnLoad(gameObject); //Μη καταστραφεί κατά τη φόρτωση 
        }
        else
        {
            Destroy(gameObject); //Αν υπάρχει Instance μη ξαναspawnάρεις την ίδια Instance έτσι ώστε να μέινει μόνο μία
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
