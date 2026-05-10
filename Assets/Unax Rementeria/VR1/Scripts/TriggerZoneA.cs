using UnityEngine;

public class TriggerZoneA : MonoBehaviour
{
    public TriggerSequenceManager manager;

    private void OnTriggerEnter(Collider other)
    {
        manager.OnTriggerAEntered();
    }
}
