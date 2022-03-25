using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _AIEnemyNavMesh;
    [SerializeField] private int _AIChaseRadius;
    [SerializeField] private int _AIAttackRadius;
    [SerializeField] private bool _AIisChasing;
    [SerializeField] private bool _AIisAttacking;
    [SerializeField] private LayerMask _PlayerLayerMask;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        _AIisChasing = Physics.CheckSphere(transform.position, _AIChaseRadius, _PlayerLayerMask);
        _AIisAttacking = Physics.CheckSphere(transform.position, _AIAttackRadius, _PlayerLayerMask);
        Chase();
    }
    void Patrol()
    {

    }
    void Chase()
    {
        if (_AIisChasing)
        {
            _AIEnemyNavMesh.SetDestination(Player.transform.position);
        }
        else
            return;
    }
    void Attack()
    {

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, _AIAttackRadius);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, _AIChaseRadius);
        Gizmos.color = Color.yellow;
    }
}
