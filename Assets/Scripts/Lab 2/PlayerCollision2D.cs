using UnityEngine;

public class PlayerCollision2D : MonoBehaviour
{
    int collisionCount = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        collisionCount++;
        Debug.Log("Va chạm lần " + collisionCount + " với: " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi vào Trigger lúc " + Time.time + " với: " + other.gameObject.name);
    }
}
