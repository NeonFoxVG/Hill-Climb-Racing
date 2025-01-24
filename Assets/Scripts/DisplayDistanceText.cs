using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayDistanceText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI distanceText;
    [SerializeField] private Transform playerTransform;
    private Vector2 startPosition;
    private void Start()
    {
        startPosition = playerTransform.position;
    }
    private void Update()
    {
        Vector2 distance = (Vector2)playerTransform.position - startPosition;
        distance.y = 0f;
        if (distance.x < 0)
        {
            distance.x = 0;
        }
        distanceText.text = distance.x.ToString("F0") + "m";
    }
}
