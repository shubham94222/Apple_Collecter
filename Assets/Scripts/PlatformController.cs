using UnityEngine;

public class PlatformController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // make the player a child of the moving collider
            collision.collider.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            // remove the player from being a child of the moving collider
            collision.collider.transform.parent = null;
        }
    }
}



