using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; //ȸ�� �ӵ�
    public float go = 0.0f;
    int count = 6;
    GameObject countText;

    void Start()
    {
        countText = GameObject.Find("countdown");
    }

    // Update is called once per frame
    void Update()
    {
        if (rotSpeed == 0)
        {
            if (Input.GetMouseButton(0)) //���콺 ��Ŭ��
            {
                rotSpeed = Random.Range(10.0f,20.0f);
            }
        }

        //ȸ���ӵ���ŭ �귿�� ȸ���Ѵ�.
        transform.Rotate(0, 0, rotSpeed);

        rotSpeed *= 0.995f;

        if (rotSpeed < 0.01f && rotSpeed != 0)
        {

            // Debug.Log($"{transform.rotation.eulerAngles.z}");

            if (transform.rotation.eulerAngles.z % 360 + 30 <= 60)
            {
                go += 2f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }
            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 120)
            {
                go += 6f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }

            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 180)
            {
                go += 1f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }

            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 240)
            {
                go += 4f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }

            else if (transform.rotation.eulerAngles.z % 360 + 30 <= 300)
            {
                go += 3f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }
            else
            {
                go += 5f;
                count -= 1;
                countText.GetComponent<TMP_Text>().text = "CountDown : " + count;
            }
            rotSpeed = 0;
        }
    }
}
