using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Player : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject player;
    public float despawnThreshold = -10.0f;
    public Vector2 startPosition;

    void Start()
    {
        player.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < despawnThreshold)
        {
            transform.position = startPosition;
        }
    }
}
