using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    [SerializeField]
    public Vector3 _desiredDestination;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<NavMeshAgent>().destination = player.position;

    }

    // Update is called once per frame
    void Update()
    {
        Start();
    }
}
