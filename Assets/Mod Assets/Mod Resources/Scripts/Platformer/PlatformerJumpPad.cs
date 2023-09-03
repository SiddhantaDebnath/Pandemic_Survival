using System.Collections;
using UnityEngine;
using Platformer.Mechanics;

public class PlatformerJumpPad : MonoBehaviour
{
    [SerializeField]public float verticalVelocity;
    [SerializeField] public float duration;

    void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(false);
        var rb = other.attachedRigidbody;
        if (rb == null) return;
        var player = rb.GetComponent<PlayerController>();
       // if (player == null) return;
        if (player == null) return;
        player.StartCoroutine(AddVelocity(player, duration));
    }

    IEnumerator AddVelocity(PlayerController player, float lifetime)
    {
        var initialSpeed = player.jumpTakeOffSpeed;
        player.jumpTakeOffSpeed = verticalVelocity;
        yield return new WaitForSeconds(lifetime);
        gameObject.SetActive(true);
        player.jumpTakeOffSpeed = initialSpeed;
    }
}
