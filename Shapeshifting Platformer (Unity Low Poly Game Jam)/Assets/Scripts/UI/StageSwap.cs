using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSwap : MonoBehaviour {

    public string[] stageScenes;
    public GameObject[] stagePreviewCameras;
    public int currentStage;
    public RenderTexture rt;

    public void loadStage()
    {
        SceneManager.LoadScene(stageScenes[currentStage], LoadSceneMode.Single);
    }
    public void nextStageSelect()
    {
        stagePreviewCameras[currentStage].SetActive(false);
        if (currentStage == stageScenes.Length - 1)
        {
            currentStage = 0;
        }
        else
        {
            currentStage += 1;
        }
        stagePreviewCameras[currentStage].SetActive(true);
    }
    public void previousStageSelect()
    {
        stagePreviewCameras[currentStage].SetActive(false);
        if (currentStage == 0)
        {
            currentStage = stageScenes.Length - 1;
        }
        else
        {
            currentStage -= 1;
        }
        stagePreviewCameras[currentStage].SetActive(true);
    }

}
