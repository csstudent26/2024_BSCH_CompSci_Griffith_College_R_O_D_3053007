

using UnityEngine;


public class PlayerSeek : MonoBehaviour
{
    public string enemyTag = "Enemy"; // Tag of the GameObjects the player seeks
    public float speed = 155f; // Speed at which the player moves towards the enemy

    void Update()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag(enemyTag);

        if (enemy != null)
        {
            transform.position = enemy.transform.position;
        }
    }
}
