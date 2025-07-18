using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject Target;

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position;
    }
}
