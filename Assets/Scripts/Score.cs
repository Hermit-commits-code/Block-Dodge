using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public Transform player;

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("0");
    }
}
