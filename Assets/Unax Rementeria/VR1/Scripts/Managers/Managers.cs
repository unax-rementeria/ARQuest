using UnityEngine;

public class Managers 
{
    public float MaxScore;
    public static Managers Instance { get; private set; }   

    // private void Awake()
    // {
    //     if (Instance != null && Instance != this)
    //     {
    //         Destroy(gameObject);
    //     }
    //     else
    //     {
    //         Instance = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    // }

    

}
