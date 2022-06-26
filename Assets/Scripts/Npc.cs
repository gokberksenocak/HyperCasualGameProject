using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Npc : MonoBehaviour
{
    public Transform _transform;
    public Transform target;
    public NavMeshAgent agent;
    private float pace;
    [SerializeField] private Vector3 _StartPos;
    [SerializeField] private GameObject _panel2;

    void Start()
    {
        _StartPos = transform.position;
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(target.position);
        pace = Random.Range(4f, 5.5f);
        agent.speed = pace;
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            transform.position = _StartPos;
            agent.SetDestination(target.position);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish2"))
        {
            _panel2.SetActive(true);
            Time.timeScale = 0;
        }
    }
}