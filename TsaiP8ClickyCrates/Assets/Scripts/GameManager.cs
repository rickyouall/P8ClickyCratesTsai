using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public GameObject[] targets2;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI GameOverText;
    private int score;
    private float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {

            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        GameOverText.gameObject.SetActive(true);

    }
}
