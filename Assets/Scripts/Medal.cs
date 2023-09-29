using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Medal : MonoBehaviour
{
    public Sprite bronzeMedal, ironMedal, goldMedal, silverMedal;
    Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        int gameScore = GameManager.gameScore;

        if (gameScore > 0 && gameScore <= 10) 
        {
            img.sprite = ironMedal;
        }
        else if (gameScore > 10 && gameScore <= 25) 
        {
            img.sprite = bronzeMedal;
        }
        else if (gameScore > 25 && gameScore <= 100) 
        {
            img.sprite = silverMedal;
        }
        else if (gameScore > 100)
        {
            img.sprite = goldMedal;
        }
    }
}
