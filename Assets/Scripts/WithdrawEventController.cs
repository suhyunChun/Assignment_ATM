using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WithdrawEventController : MonoBehaviour
{
    [SerializeField] private TMP_InputField usrTxt;
    [SerializeField] private TextMeshProUGUI cash;
    [SerializeField] private TextMeshProUGUI balance;
    public GameObject panel;
    // Start is called before the first frame update

    private int currCash;
    private int currBalance;


    public void WithdrawWithUsrTxt()
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currBalance - int.Parse(usrTxt.text) >= 0)
        {
            currCash += int.Parse(usrTxt.text);
            currBalance -= int.Parse(usrTxt.text);
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }
        usrTxt.text = "";

    }

    public void WithdrawWithBtn(int number)
    {
        currCash = int.Parse(cash.text);
        currBalance = int.Parse(balance.text);
        if (currBalance - number >= 0)
        {
            currCash += number;
            currBalance -= number;
            balance.text = currBalance.ToString();
            cash.text = currCash.ToString();
        }
        else
        {
            panel.SetActive(true);
        }

    }
}
