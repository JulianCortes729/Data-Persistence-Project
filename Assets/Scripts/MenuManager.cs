using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public string nombre;

    public static MenuManager Instance;
    private void Awake(){

        if(MenuManager.Instance != null){
            Destroy(gameObject);
            return;
        }

        MenuManager.Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
