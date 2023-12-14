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

    public UserData userData;
    [SerializeField] private TextMeshProUGUI cash;
    [SerializeField] private TextMeshProUGUI balance;

    private void Awake()
    {
        I = this; //ΩÃ±€≈Ê 
       
    }


    private void Start()
    {
        cash.text = userData.cash.ToString();
        balance.text = userData.balance.ToString();

        
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
