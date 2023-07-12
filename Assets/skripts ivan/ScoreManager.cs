using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int scoretxt = 0;
    private int money = 0;
    private bool AlreadyGetYouMoney = false; //chech to get money

    [SerializeField] private int HP = 3;
    [SerializeField] bool cheat = true;
    [SerializeField] bool reset = false;
    [SerializeField] public GameObject LosePanel;
    [SerializeField] public GameObject Scoretxt;
    [SerializeField] public GameObject HpPanel;

    [SerializeField] Text moneytxt;
    [SerializeField] Text ScoreText;
    [SerializeField] Text HPtxt;

    [SerializeField] public int scorePlus = 0;
    [SerializeField] public int scoreMinuss = 0;

    [SerializeField] public HammerColiderBoltPunching HammerColiderObject;



    void Start()
    {
        scoretxt = 0;
        money = PlayerPrefs.GetInt("money");

        if (reset)
        {
            PlayerPrefs.DeleteKey("money");
        }
    }

    void Update()
    {

        ScoreText.text = scoretxt.ToString();
        HPtxt.text = HP.ToString();

        if (HP <= 0 && cheat == false) //game over
        {
            LosePanel.SetActive(true);
            Scoretxt.SetActive(false);
            Time.timeScale = 0f;

            if (AlreadyGetYouMoney == false) //get money
            {
                money += scoretxt;
                moneytxt.text = money.ToString();
                PlayerPrefs.SetInt("money", money);
                AlreadyGetYouMoney = true;
            }
        }
        

        if (scorePlus > scoreMinuss) //score plus
        {
            scoretxt = scoretxt + 1;
            scorePlus = 0;
            scoreMinuss = 0;
            HammerColiderObject.ObjectNeedDestruction = 1;
        }
        else
        {
            if((scorePlus < scoreMinuss) || (scorePlus==1 && scoreMinuss==1)) //scoreminus
            {
                scoretxt = scoretxt - 1;
                HP -= 1;
                scorePlus = 0;
                scoreMinuss = 0;
                HammerColiderObject.ObjectNeedDestruction = 2;
            }
            
        }
    }

    public void Event(int ScoreDamage=1,int HpDamage=0)
    {
        scoretxt = scoretxt + ScoreDamage;
        HP += HpDamage;

        //space for some epic shit 

    }

    public void MinusScoreFunc()
    {
        scoretxt = scoretxt - 1;
    }
}
