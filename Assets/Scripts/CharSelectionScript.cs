using UnityEngine;

public class CharSelectionScript : MonoBehaviour
{
    [SerializeField] GameObject scoreCanvas;
    [SerializeField] GameObject dinosprite;
    [SerializeField] GameObject frogsprite;
    void Start()
    {
        Time.timeScale = 0;
        scoreCanvas.SetActive(false);
    }

    void BeginGame()
    {
        Time.timeScale = 1f;
        scoreCanvas.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ChooseDino()
    {
        dinosprite.SetActive(true);
        BeginGame();
    }

    public void ChooseFrog()
    {
        frogsprite.SetActive(true);
        BeginGame();
    }



}
