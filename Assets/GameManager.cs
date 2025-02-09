using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string nextSceneName;
    private GameObject text;
    private GameObject restartButton;

    private GameObject nextButton;

    private GameObject[] blocks;

    // Start is called before the first frame update
    void Start()
    {
        text = GameObject.Find("Text");
        restartButton = GameObject.Find("RestartButton");
        nextButton = GameObject.Find("NextButton");
        restartButton.SetActive(false);


        blocks = GameObject.FindGameObjectsWithTag("Block");
    }

    // Update is called once per frame
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");
        if (blocks.Length==0)
        {
            GameClear();
        }
    }
    public void GameOver()
    {
        text.GetComponent<Text>().text = "Game Over";
        restartButton.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameClear()
    {
        text.GetComponent<Text>().text="Game Clear";
        nextButton.SetActive(true);
    }
    public void NextStage()
    {
        SceneManager.LoadScene(nextSceneName);
    }
    private IEnumerator ShowStageName()
    {
        text.GetComponent<Text>().text = SceneManager.GetActiveScene().name;
        yield return new WaitForSeconds(2.0f);
        text.GetComponent<Text>().text = "";

    }
}
