using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private int direction;
    private int speed;
    [SerializeField] private int number;

    void Start()
    {
        if (number==1)
        {
            direction = 1;
            speed = 10;
        }
        if (number==2)
        {
            direction = -1;
            speed = 11;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Side"))
        {
            direction *= -1;
        }
    }
    void FixedUpdate()
    {
        transform.Translate(direction * speed * Time.deltaTime * Vector3.right);
    }
}