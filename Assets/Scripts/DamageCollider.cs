using UnityEngine;

public class DamageCollider : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = FindObjectOfType<LivesDisplay>();
        Destroy(otherCollider.gameObject);
        health.TakeLife();
    }
}
