using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Slider scoreSlider;

    //スコア最大値
    private float maxScore = 100;

    //１ノーツのスコア
    public float score;

    //合計スコア
    public static float totalScore;

    void Start()
    {
        scoreSlider.maxValue = maxScore;
        scoreSlider.value = 0;

        //totalScore = 0;
    }

    void Update()
    {
        totalScore = scoreSlider.value;
    }

    public void Push()
    {
        scoreSlider.value += score;
        this.gameObject.SetActive(false);
        Invoke("Return", 0.5f);
    }

    void Return()
    {
        this.gameObject.SetActive(true);
    }
}
