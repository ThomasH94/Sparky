using TMPro;
using UnityEngine;

public class UIDialogueBubble : UIPrompt {

    [SerializeField]
    private TMP_Text _textField;

    public override void show(params object[] args)
    {
        string dialogue = string.Empty;

        for (int i = 0; i < args.Length; i++)
        {
            if(args[i] is string)
            {
                dialogue = (string)args[i];
                break;
            }
        }

        if (string.IsNullOrEmpty(dialogue))
            return;

        _textField.text = dialogue;

        base.show();
    }
}