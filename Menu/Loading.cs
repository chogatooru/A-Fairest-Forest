using System.Collections;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour {

    public GameObject loadingScreenObj;
    public Slider slider;

    AsyncOperation async;

    public void LoadScreenExample(int LVL){
        Global.flowercoll = false;
        Global.dialoguecoll = false;
        Global.checkforend = 0;
        Global.flower = 0;
    StartCoroutine(LoadingSreen(LVL));
}
    IEnumerator LoadingSreen(int lvl){
    loadingScreenObj.SetActive(true);
    async = SceneManager.LoadSceneAsync(lvl);
    async.allowSceneActivation = false;

    while (async.isDone == false)
    {
        slider.value = async.progress;
        if (async.progress == 0.9f)
        {
            slider.value = 1f;
            async.allowSceneActivation = true;
        }
        yield return null;
    }

}
}
