using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public string nombre;
    public Text bestScoreMenuText;
    public static MenuManager Instance;
    private void Awake(){

        if(MenuManager.Instance != null && MenuManager.Instance != this){
            Destroy(gameObject);
            return;
        }

        MenuManager.Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadData();
    }


    public void LoadData(){
        string path = Application.persistentDataPath+"/savefile.json";
        if(File.Exists(path)){
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            MenuManager.Instance.bestScoreMenuText.text = "Best Score : "+ data.nombre + " : " + $"{data.score}";
        }
    }
}
