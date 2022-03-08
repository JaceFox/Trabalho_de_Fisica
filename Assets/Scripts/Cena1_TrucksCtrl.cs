using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cena1_TrucksCtrl : MonoBehaviour
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

    int velA = 0;
    int tempValA = 0;
    int SoA = 300;
    float SA;
    int SAint;

    int velB = 0;
    int tempValB = 0;
    float SB;
    int SBint;

    float t = 0;
    int tempo;

    void Start()
    {
        UIProb.SetActive(true);
        UIGame.SetActive(false);
        UIWin.SetActive(false);
        UILose.SetActive(false);
        TruckA.transform.position = new Vector2(300f, -2f);
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
            SB = velB * t;
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
        velB = tempValB;

        UIProb.SetActive(false);
        UIGame.SetActive(true);
        TruckA.SetActive(true);
        TruckB.SetActive(true);
    }

    //Valores de A ---------------------------------------------------------- Valores de A ---------------------------------------------------------- Valores de A
    public void BtnVAto10()
    {
        tempValA = 10;
    }
    public void BtnVAto15()
    {
        tempValA = 15;
    }
    public void BtnVAto20()
    {
        tempValA = 20;
    }
    public void BtnVAto30()
    {
        tempValA = 30;
    }

    //Valores de B ---------------------------------------------------------- Valores de B ---------------------------------------------------------- Valores de B
    public void BtnVBto45()
    {
        tempValB = 45;
    }
    public void BtnVBto50()
    {
        tempValB = 50;
    }
    public void BtnVBto62()
    {
        tempValB = 62;
    }
    public void BtnVBto70()
    {
        tempValB = 70;
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
        if(velA == 20 && velB == 50 && SA <= SB)
        {
            UIWin.SetActive(true);
        }
        else if (velA != 0 && velA != 20 && velB != 0 && velB != 50 && SA <= SB)
        {
            UILose.SetActive(true);
        }
    }
}