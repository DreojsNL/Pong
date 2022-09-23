using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using TMPro;

public class LSD : MonoBehaviour
{
    private float Timer = 0.05f;

    private Color color;

    public Material NietWit;

    public TextMeshProUGUI[] LSDText;

    private void Update()
    {
        Timer -= Time.deltaTime;

        if (Timer <= 0)
        {
            color = Random.ColorHSV(0f, 1f, 0.8f, 1f, 0.8f, 1f);
            NietWit.color = color;
            for (int i = 0; i < LSDText.Length; i++)
            {
                LSDText[i].color = color;
            }
            Timer = 0.05f;
        }
    }
}