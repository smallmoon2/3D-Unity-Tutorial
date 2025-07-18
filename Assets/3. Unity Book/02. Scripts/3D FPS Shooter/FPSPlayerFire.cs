using UnityEngine;

public class FPSPlayerFire : MonoBehaviour
{
    public GameObject firePosition;
    public GameObject bombFactory;

    public float throwPower = 15f;
    public GameObject bulletEffecct;
    private ParticleSystem ps;

    private void Start()
    {
        ps = bulletEffecct.GetComponent<ParticleSystem>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            RaycastHit hitInfo = new RaycastHit();

            Debug.Log("Å¬¸¯");
            if (Physics.Raycast(ray, out hitInfo))
            {
                bulletEffecct.transform.position = hitInfo.point;
                bulletEffecct.transform.forward = hitInfo.normal;
                ps.Play();
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            GameObject bomb = Instantiate(bombFactory);
            bomb.transform.position = firePosition.transform.position;

            Rigidbody rb = bomb.GetComponent<Rigidbody>();

            rb.AddForce(Camera.main.transform.forward * throwPower, ForceMode.Impulse);
        }
    }
}
