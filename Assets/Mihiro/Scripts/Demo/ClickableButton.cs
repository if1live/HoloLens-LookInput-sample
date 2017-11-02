using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Mihiro.Scripts.Demo {
    public class ClickableButton : MonoBehaviour {
        [SerializeField]
        Button button = null;

        [SerializeField]
        Text text = null;

        int clickCount = 0;
        void Start() {
            button.onClick.AddListener(OnClick);
            text.text = string.Format("click: {0}", clickCount);
        }

        void OnClick() {
            clickCount += 1;
            text.text = string.Format("click: {0}", clickCount);
        }
    }
}