using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cena2_TrucksCtrl : MonoBehaviour
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
    int SoA = 200;
    int SAint;
    int velA = 0;
    int tempValA = 20;

    float SB;
    int SBint;
    int velB = 0;
    int tempVelB = 30;
    int acelB = 0;
    int tempAcelB = 0;

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

        UIProb.SetActive(false);
        UIGame.SetActive(true);
        TruckA.SetActive(true);
        TruckB.SetActive(true);
    }

    //Valores de B ---------------------------------------------------------- Valores de B ---------------------------------------------------------- Valores de B
    public void BtnAcelBto4()
    {
        tempAcelB = 4;
    }
    public void BtnAcelBto6()
    {
        tempAcelB = 6;
    }
    public void BtnAcelBto8()
    {
        tempAcelB = 8;
    }
    public void BtnAcelBto10()
    {
        tempAcelB = 10;
    }
    public void BtnAcelBto12()
    {
        tempAcelB = 12;
    }
    public void BtnAcelBto14()
    {
        tempAcelB = 14;
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
        if (acelB == 12 && SA <= SB)
        {
            UIWin.SetActive(true);
        }
        else if (acelB != 0 && acelB != 12 && SA <= SB)
        {
            UILose.SetActive(true);
        }
    }
}