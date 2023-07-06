using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    public void GameOver()
    {
        gameOverCanvas.gameObject.SetActive(true);
    }
}
