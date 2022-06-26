using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class RacePosition : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Transform[] Objects;
    private float[] Distances= new float[11];
    private float[] Order = new float[11];

    void FixedUpdate()
    {
        for (int i = 0; i < Distances.Length; i++)
        {
            Distances[i] = Vector3.Distance(transform.position, Objects[i].position);
        }
        Array.Sort(Distances);

        for (int i = 0; i < Distances.Length; i++)
        {
            Order[i] = Distances[i];
        }

        float PlayerDist = Vector3.Distance(transform.position, Objects[0].position);
        if (PlayerDist == Order[0])
        {
            _text.text = "Sýra: 1.";
        }
        if (PlayerDist == Order[1])
        {
            _text.text = "Sýra: 2.";
        }
        if (PlayerDist == Order[2])
        {
            _text.text = "Sýra: 3.";
        }
        if (PlayerDist == Order[3])
        {
            _text.text = "Sýra: 4.";
        }
        if (PlayerDist == Order[4])
        {
            _text.text = "Sýra: 5.";
        }
        if (PlayerDist == Order[5])
        {
            _text.text = "Sýra: 6.";
        }
        if (PlayerDist == Order[6])
        {
            _text.text = "Sýra: 7.";
        }
        if (PlayerDist == Order[7])
        {
            _text.text = "Sýra: 8.";
        }
        if (PlayerDist == Order[8])
        {
            _text.text = "Sýra: 9.";
        }
        if (PlayerDist == Order[9])
        {
            _text.text = "Sýra: 10.";
        }
        if (PlayerDist == Order[10])
        {
            _text.text = "Sýra: 11.";
        }
    }
}