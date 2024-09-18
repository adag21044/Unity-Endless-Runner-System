using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }

    // This is a built-in Unity method that is called when the object becomes non-visible to the camera
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}