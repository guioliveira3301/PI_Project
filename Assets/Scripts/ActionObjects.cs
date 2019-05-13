using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ActionObjects : MonoBehaviour
{

    [SerializeField] private SceneObjects[] objects;

    public void ChangeScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }

    public void DisableObject(string objName){
        for(int i = 0; i < objects.Length; i++){
            if(objects[i].name == objName){
                objects[i].obj.SetActive(false);
            }
        }
    }

    public void EnableObject(string objName){
        for(int i = 0; i < objects.Length; i++){
            if(objects[i].name == objName){
                objects[i].obj.SetActive(true);
            }
        }
    }
}
