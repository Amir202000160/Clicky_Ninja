using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyBtn : MonoBehaviour
{
    // Start is called before the first frame update
    private Button btn;
    private GameManager gameManager;
    public int difficulty;
    void Start()
    {
        btn= GetComponent<Button>();
        btn.onClick.AddListener(SetDifficulty);
        gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        gameManager.StartGame(difficulty);
    }
}
