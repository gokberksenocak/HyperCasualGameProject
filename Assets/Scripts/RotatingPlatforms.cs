using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatforms : MonoBehaviour
{
    [SerializeField] private int no;
    private float pace = 100f;
    void FixedUpdate()
    {
         if (no==0)
         {
             transform.Rotate(0f, 0f, -pace * Time.deltaTime);
         }
         if (no == 1)
         {
             transform.Rotate(0f, 0f, pace * Time.deltaTime);
         }
    }
}