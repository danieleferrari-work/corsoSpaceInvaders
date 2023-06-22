using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;

    public void OnGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
