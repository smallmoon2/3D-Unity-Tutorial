using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    private Transform player;
    private NavMeshAgent agent;

    public Transform[] points;
    public int index;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(points[index].position);

        if (agent.remainingDistance <= 1.5f) // ���������� �Ÿ��� 1.5 ������ ���
        {
            Debug.Log("������ ����");
            index++;

            if (index >= points.Length)
                index = 0;
        }
    }
}