using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button tankSelector;
    private void Start()
    {
        tankSelector.onClick.AddListener(onButtonClick);
    }

    public void onButtonClick()
    {
        Debug.Log("Button clicked");
    }
}
