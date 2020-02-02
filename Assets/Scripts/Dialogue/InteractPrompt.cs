using UnityEngine;

public class InteractPrompt : UIPrompt
{
    public override void show(params object[] args)
    {
        Vector3 position = Vector3.zero;

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i] is Vector3)
            {
                position = (Vector3)args[i];
                break;
            }
        }

        mainObject.transform.position = position;

        base.show();
    }
}
