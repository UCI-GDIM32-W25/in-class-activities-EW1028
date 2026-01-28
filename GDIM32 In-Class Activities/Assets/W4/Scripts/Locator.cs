using UnityEngine;

public class Locator : MonoBehaviour {
    public static Locator Instance { get; private set; }
    public static W4Pigeon Pigeon { get; private set; }

private void Awake () {
    if (Instance != null && Instance != this){
        Destroy(this);
        return;
    }

    Instance = this;

    GameObject playerObj = GameObject.FindWithTag("Player");
    Debug.Log("playerObj" + playerObj);
    Pigeon = playerObj.GetComponent<W4Pigeon>();
}


}
