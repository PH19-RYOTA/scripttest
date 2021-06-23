using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayTimeline : MonoBehaviour
{
    public PlayableDirector START;
    public float nanbyou;

    void Start()
    {
        Invoke("Timeline", nanbyou);
    }

    void Update()
    {
        
    }

    void Timeline()
    {
        START.Play();
    }
}
