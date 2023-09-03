using Platformer.Core;
using Platformer.Model;
using UnityEngine;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a gameobject as a spawnpoint in a scene.
    /// </summary>
    public class SpawnPoint : MonoBehaviour
    {
        PlatformerModel model;
        private void Awake()
        {
            model = Simulation.GetModel<PlatformerModel>();
        }
        private void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                model.spawnPoint.transform.position = gameObject.transform.position;
            }
        }
    }
}