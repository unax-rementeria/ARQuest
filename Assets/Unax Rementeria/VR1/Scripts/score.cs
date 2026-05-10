using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class score : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI scoreText;

    [Header("Settings")]
    [SerializeField] private string prefix = "Score: ";



    public int _score = 0;
    public int MaxScore = -1;

    puntos puntos;

    public static score Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void FixedUpdate()
    {
        if (puntos.Max5)
        {
            MaxScore = 5;
            Debug.Log("Max Score: " + MaxScore);
        }
        else if (puntos.Max10)
        {
            MaxScore = 10;
            Debug.Log("Max Score: " + MaxScore);
        }
        else if (puntos.Max20)
        {
            MaxScore = 20;
            Debug.Log("Max Score: " + MaxScore);
        }else if (puntos.Max40)
        {
            MaxScore = 40;
            Debug.Log("Max Score: " + MaxScore);
        }
        else if (puntos.Max60)
        {
            MaxScore =60;
            Debug.Log("Max Score: " + MaxScore);
        }
        // UpdateDisplay();
    }

    void Start()
    {
        UpdateDisplay();
        Debug.Log("Max Score: " + MaxScore);
        Debug.Log("Current Score: " + _score);
    }

    public void AddScore()
    {
        
        _score ++;
        UpdateDisplay();
    }

    public void MinusScore()
    {
        _score = _score - 1;
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        if (_score < MaxScore)
        {
            scoreText.text = prefix + _score.ToString();
        }
        else if (_score >= MaxScore)
        {
            scoreText.text = "Has Ganado!";
        }
    }
}
