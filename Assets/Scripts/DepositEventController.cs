using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DepositEventController : MonoBehaviour
{

    [SerializeField] private TMP_InputField usrTxt;
    [SerializeField] private TextMeshProUGUI cash;
    [SerializeField] private TextMeshProUGUI balance;
    public GameObject panel;
    // Start is called before the first frame update

    private int currCash;
    private int currBalance;



    public void DepositWithUsrTxt()
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currCash - int.Parse(usrTxt.text) >= 0)
        {
            currBalance += int.Parse(usrTxt.text);
            currCash -= int.Parse(usrTxt.text);
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        usrTxt.text = "";

    }

    public void DepositWithBtn(int number) {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currCash - number >= 0)
        {
            currBalance += number;
            currCash -= number;
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }


}
