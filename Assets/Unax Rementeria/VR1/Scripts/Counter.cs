using Unity.VisualScripting;
using UnityEngine;

public class Counter : MonoBehaviour
{
    score score;

    [System.Obsolete]
    void Start()
    {
        score = FindObjectOfType<score>(); // find it in the scene

        if (score == null)
            Debug.LogError("No Score object found in the scene!", this);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("proyectil"))
        {
            score.AddScore();
            Destroy(other.gameObject);
        }

        

        if (other.transform.CompareTag("bomb"))
        {
            score.MinusScore();
            Destroy(other.gameObject);
        }

        
    }
}
