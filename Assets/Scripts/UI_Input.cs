using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Input : MonoBehaviour
{
    public Image imgCircle;
    public float limitTime = 2f;
    [SerializeField] private bool gvrStatus;
    [SerializeField] private ActionObjects actionObjects;
    public float gvrTimer;
    public string sceneName;
    private string objectPoint;

    void Update()
    {
        if(gvrStatus){
            if(gvrTimer < limitTime){
                gvrTimer += Time.deltaTime;
                imgCircle.fillAmount = gvrTimer/limitTime;
            }
            else {
                if(objectPoint == "ZZ")
                    return;

                print(objectPoint.Substring(0, 1));

                if(objectPoint.Substring(0, 1) != "!"){
                    actionObjects.EnableObject(objectPoint);
                    gvrTimer = 0f;
                }

                else if(objectPoint.Substring(0, 1) == "!"){
                    actionObjects.DisableObject(objectPoint.Substring(1));
                    gvrTimer = 0f;
                }
            }
        }
    }

    public void SetObjectPointing(string name){
        objectPoint = name;
    }

    public void SceneSwitch()
    {
        SceneManager.LoadScene (sceneName);
    }

    public void GvrOn()
    {
        gvrStatus = true;
    }

    public void GvrOff()
    {
       gvrStatus = false;
       gvrTimer = 0f;
       imgCircle.fillAmount = 0; 
    }
}
