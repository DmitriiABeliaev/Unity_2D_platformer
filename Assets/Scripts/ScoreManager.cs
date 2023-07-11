using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text text;
    int score; 

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }
    
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        //instance = this;
        text.text = " " + score.ToString();        
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = " " + score.ToString();
    }
}