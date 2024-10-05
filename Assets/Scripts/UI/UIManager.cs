using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private List<Button> tankSelectorButtons;
    private void OnEnable()
    {
        foreach (Button button in tankSelectorButtons)  // add listener to all the buttons
        {
            button.onClick.AddListener(onButtonClick);
        } 
    }

    public void onButtonClick()
    {
        SceneManager.LoadScene(1);
    }
}
