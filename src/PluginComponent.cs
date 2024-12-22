using UnityEngine;

namespace InfiniteMinigames;

public class InfiniteMinigames : MonoBehaviour {
    void Update() {
        if (Input.GetKeyDown(KeyCode.F3)) {
            Plugin.allowInfiniteMinigames = !Plugin.allowInfiniteMinigames;
            Plugin.Log.LogInfo(string.Format("Infinite Minigames is now {0}", Plugin.allowInfiniteMinigames));
        }
        if (Input.GetKeyDown(KeyCode.F2)) {
            GameController gameController = GlobalTag.gameController.GetComponent<GameController>();
            if (!gameController.tetrisPlay) {
                gameController.TetrisStart();
                Plugin.Log.LogInfo("Tetris equipped");
            }
        }
    }
}
