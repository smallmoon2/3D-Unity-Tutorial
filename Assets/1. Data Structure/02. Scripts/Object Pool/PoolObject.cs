using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private ObjectPoolQueue pool;
    private int bulletSpeed = 5;

    void Awake()
    {
        pool = FindFirstObjectByType<ObjectPoolQueue>();
    }

    void OnEnable()
    {
        Invoke("ReturnPool", 3f);
    }

    private void ReturnPool()
    {
        pool.EnqueueObject(gameObject);
    }

    private void Update()
    {
        transform.position += Vector3.forward * Time.deltaTime * bulletSpeed;
    }
}