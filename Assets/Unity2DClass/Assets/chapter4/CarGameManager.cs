using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CarGameManager : MonoBehaviour
{
    CarController carController;
    GameObject car;
    GameObject flag;
    GameObject distanceText;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("car");
        flag = GameObject.Find("flag");
        distanceText = GameObject.Find("Distance");

        carController = car.GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        float length = flag.transform.position.x - car.transform.position.x;

        if (length < 0)
        {
            distanceText.GetComponent<TMP_Text>().text = "Lose!!!";
            carController.Judgement = false;
        }
        else if (length <= 0.5f)
        {
            distanceText.GetComponent<TMP_Text>().text = "Win!!!";
            carController.Judgement = false;
        }
        else
        {
            distanceText.GetComponent<TMP_Text>().text = "Distance : " + length.ToString("F2") + "m";
            if (carController.count == 6)
            {
                distanceText.GetComponent<TMP_Text>().text = "Lose!!!";
                carController.Judgement = false;
            }
        }
    }
}
