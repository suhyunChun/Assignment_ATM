using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public static GameManager I;
    public GameObject panel;
    public GameObject BtnContainer;
    public GameObject DContainer;
    public GameObject WContainer;
    private void Awake()
    {
        I = this; //ΩÃ±€≈Ê 
       
    }

    public void GoBack()
    {
        panel.SetActive(false);
    }

    public void ShowDeposit()
    {
        BtnContainer.SetActive(false);
        DContainer.SetActive(true);

    }
    public void ShowWithDraw()
    {
        BtnContainer.SetActive(false);
        WContainer.SetActive(true);
    }

    public void GoBackMenu()
    {
        DContainer.SetActive(false);
        WContainer.SetActive(false);
        BtnContainer.SetActive(true);
    }
}
