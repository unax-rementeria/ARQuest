using UnityEngine;

public class GeneralManager : MonoBehaviour
{
    public static GeneralManager Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
