using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenManager : MonoBehaviour
{
    public void OnClickButtonStart()
    {
        SceneManager.LoadScene(Const.Scenes.Level1);
    }

    public void OnClickButtonExit()
    {
        Application.Quit();

        // far vedere prima solo Application.Quit() e poi aggiungere queste righe
        // in modo che anche il tasto exit faccia qualcosa anche in editor
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#endif
    }
}
