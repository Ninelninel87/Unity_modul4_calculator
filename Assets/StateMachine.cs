using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
   [SerializeField]private GameObject first_canvas;
   [SerializeField] private GameObject second_canvas;

    private GameObject currentScreen;

    private void Start()
    {
        first_canvas.SetActive(true);
        currentScreen = first_canvas;
    }
    public void ChangeState(GameObject state)
    {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }

