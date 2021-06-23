using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("タイムバー")] Slider TimeBar;

    [SerializeField, Header("音楽合計時間")] float TotalTime;

    //Timeline再生
    public PlayableDirector START;
    public float nanbyou;
    bool start;
    public GameObject Notes;

    //Fade
    [SerializeField,Header("フェードパネル")] GameObject FadeObj;
    [SerializeField,Header("フェードアニメーション")] PlayableDirector fade;
    [SerializeField,Header("フェードタイム")] float fadeTime;

    //リザルト
    [SerializeField]
    GameObject resultPanel;

    void Start()
    {
        TimeBar.maxValue = TotalTime;
        TimeBar.value = TotalTime;
        Notes.SetActive(false);
        FadeObj.SetActive(false);
        resultPanel.SetActive(false);
        
        Invoke("Timeline", nanbyou);
    }

    void Update()
    {
        if(start)
        {
            TimeBar.value -= 1 * Time.deltaTime;
            TotalTime -= 1 * Time.deltaTime;

            if (TimeBar.value <= 0)
            {
                FadeObj.SetActive(true);
                Fade();
            }

            
        }
    }

    void Timeline()
    {
        Notes.SetActive(true);
        START.Play();
        start = true;
    }

    void Fade()
    {
        fade.Play();
        Invoke("Change", fadeTime);
    }

    void Change()
    {
        resultPanel.SetActive(true);
    }
}
