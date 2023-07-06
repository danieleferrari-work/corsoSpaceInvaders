using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;
    [SerializeField] Canvas winCanvas;

    public void GameOver()
    {
        gameOverCanvas.gameObject.SetActive(true);
    }

    public void YouWin()
    {
        winCanvas.gameObject.SetActive(true);
    }
}
