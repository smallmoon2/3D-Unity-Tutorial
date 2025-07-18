using UnityEngine;

public class DestroyEffect : MonoBehaviour
{
    public float destroyTime = 1.5f;

    private float currentTime = 0f;

    void Update()
    {
        if (currentTime > destroyTime)
        {
            Destroy(gameObject);
        }

        currentTime += Time.deltaTime;
    }

}