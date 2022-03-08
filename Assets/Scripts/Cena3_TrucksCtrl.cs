using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cena3_TrucksCtrl : MonoBehaviour
{
    [SerializeField] GameObject UIProb;
    [SerializeField] GameObject UIGame;
    [SerializeField] GameObject UIWin;
    [SerializeField] GameObject UILose;
    [SerializeField] Text PosA;
    [SerializeField] Text PosB;
    [SerializeField] Text Tempo;

    [SerializeField] GameObject TruckA;
    [SerializeField] GameObject TruckB;

    float SA;
    int SoA = 40;
    int SAint;
    int velA = 0;
    int tempValA = 12;

    float SB;
    int SBint;
    int velB = 0;
    int tempVelB = 15;
    int acelB = 0;
    int tempAcelB = 2;

    int posFinal;
    int tempPosFinal;

    float t = 0;
    int tempo;

    void Start()
    {
        UIProb.SetActive(true);
        UIGame.SetActive(false);
        UIWin.SetActive(false);
        UILose.SetActive(false);
        TruckA.transform.position = new Vector2(SoA, -2f);
        TruckB.transform.position = new Vector2(0f, -2f);
    }

    void Update()
    {
        TrucksMovement();
        Texts();
        WinCondition();
    }

    void TrucksMovement()
    {
        if (SB <= SA && velA != 0)
        {
            t += Time.deltaTime;
            SA = SoA + velA * t;
            SB = velB * t + (acelB * (t * t)) / 2;
        }
        else
        {
            t += 0;
            SA += 0;
            SB += 0;
        }

        TruckA.transform.position = new Vector2(SA, -2f);
        TruckB.transform.position = new Vector2(SB, -2f);
    }


    //BUTTONS THAT SET TRUCKS' SPEED ------------------------------- BUTTONS THAT SET TRUCKS' SPEED ------------------------------- BUTTONS THAT SET TRUCKS' SPEED
    public void BtnSetValorsAtStart()
    {
        velA = tempValA;
        velB = tempVelB;
        acelB = tempAcelB;
        posFinal = tempPosFinal;

        UIProb.SetActive(false);
        UIGame.SetActive(true);
        TruckA.SetActive(true);
        TruckB.SetActive(true);
    }

    //Valores de B ---------------------------------------------------------- Valores de B ---------------------------------------------------------- Valores de B
    public void BtnPosFinalto60()
    {
        tempPosFinal = 60;
    }
    public void BtnPosFinalto85()
    {
        tempPosFinal = 85;
    }
    public void BtnPosFinalto90()
    {
        tempPosFinal = 90;
    }
    public void BtnPosFinalto100()
    {
        tempPosFinal = 100;
    }
    public void BtnPosFinalto115()
    {
        tempPosFinal = 115;
    }
    public void BtnPosFinalto120()
    {
        tempPosFinal = 120;
    }


    //UI TEXTS IN GAME ---------------------------------------------------- UI TEXTS IN GAME ---------------------------------------------------- UI TEXTS IN GAME
    void Texts()
    {
        tempo = (int)t;
        SAint = (int)SA;
        SBint = (int)SB;

        PosA.text = SAint.ToString();
        PosB.text = SBint.ToString();
        Tempo.text = tempo.ToString();
    }


    //WIN/LOSE UI ------------------------------------------------------------ WIN/LOSE UI ----------------------------------------------------------- WIN/LOSE UI
    void WinCondition()
    {
        if (posFinal == 100 && SA <= SB)
        {
            UIWin.SetActive(true);
        }
        else if (posFinal != 0 && posFinal != 100 && SA <= SB)
        {
            UILose.SetActive(true);
        }
    }
}
