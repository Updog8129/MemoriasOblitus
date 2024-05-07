using UnityEngine;

public class MoveTowardsStart : MonoBehaviour
{
    private Vector3 originalPosition;
    private bool movingBackwards = false;

    public float backwardsDistance = 10f;
    public float returnSpeed = 5f;

    void Start()
    {
        originalPosition = transform.position;
        transform.Translate(-Vector3.right * backwardsDistance);
    }

    void Update()
    {
        if (movingBackwards)
        {
            transform.position = Vector3.MoveTowards(transform.position, originalPosition, returnSpeed * Time.deltaTime);
            if (transform.position == originalPosition)
            {
                movingBackwards = false;
            }
        }
    }

    public void SetBool(bool setBool)
    {
        movingBackwards = setBool;
    }
}