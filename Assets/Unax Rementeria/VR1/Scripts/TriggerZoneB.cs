using UnityEngine;

public class TriggerZoneB : MonoBehaviour
{
    public TriggerSequenceManager manager;
    score score;

    private void OnTriggerEnter(Collider other)
    {
        manager.OnTriggerBEntered();
        score.AddScore();
        Destroy(gameObject);
    }
}
