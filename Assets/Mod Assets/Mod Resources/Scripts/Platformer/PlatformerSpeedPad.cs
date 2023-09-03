using System.Collections;
using UnityEngine;
using Platformer.Mechanics;

public class PlatformerSpeedPad : MonoBehaviour
{
    [SerializeField]public float maxSpeed;
    [SerializeField] public float duration;

    void OnTriggerEnter2D(Collider2D other){
        Destroy(gameObject);
        var rb = other.attachedRigidbody;
        if (rb == null) return;
        var player = rb.GetComponent<PlayerController>();
        if (player == null) return;
        player.StartCoroutine(PlayerModifier(player, duration));
    }

    IEnumerator PlayerModifier(PlayerController player, float lifetime){
        var initialSpeed = player.maxSpeed;
        player.maxSpeed = maxSpeed;
        yield return new WaitForSeconds(lifetime);
        player.maxSpeed = initialSpeed;
    }
    

}
