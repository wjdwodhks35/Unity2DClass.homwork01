using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarController : MonoBehaviour
{
    RouletteController rouletteController;

    public bool Judgement = true;
    public int count = 0;
    GameObject distanceText;

    void Start()
    {
        distanceText = GameObject.Find("Distance");
        rouletteController = GameObject.Find("roulette").GetComponent<RouletteController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Judgement)
        {
            if (rouletteController.go != 0)
            {
                Vector2 movingX = new Vector2(rouletteController.go + transform.position.x, transform.position.y);
                Vector2 movingY = new Vector2(0,0);
                transform.position = Vector2.MoveTowards(movingX,movingY,0);
               
                rouletteController.go = 0;
                count++;
            }
        }
    }
}
