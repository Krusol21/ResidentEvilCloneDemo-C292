using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreTxt;
    [SerializeField] private TextMeshProUGUI healthTxt;

    public delegate void OnZombieDie();
    public event OnZombieDie zombieDeath;

    // Start is called before the first frame update
    void Start()
    {
        scoreTxt = GameObject.Find("ScoreTxt").GetComponent<TextMeshProUGUI>();
        healthTxt = GameObject.Find("HealthTxt").GetComponent<TextMeshProUGUI>();

        zombieDeath += TestFunction;

        if (zombieDeath != null )
        {
            zombieDeath.Invoke();
        }
    }

    public void TestFunction()
    {
        Debug.Log("Test");
    }
}
