using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cena1_MenuCtrl : MonoBehaviour
{
    public void BtnReloadScene()
    {
        SceneManager.LoadScene("Problema_1_-_MRU");
    }
    public void BtnBackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}