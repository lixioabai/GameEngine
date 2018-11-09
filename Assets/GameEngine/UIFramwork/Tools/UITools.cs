using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 关于UI 的工具
/// </summary>
public class UITools : MonoBehaviour
{



    /// <summary>
    /// 改变高亮和自身图片
    /// </summary>
    /// <param name="picturePath"></param>
    /// <param name="picturelinePath"></param>
    public static void ChangeButtonPicture(Button btnName,string picturePath, string picturelinePath)
    {
        btnName.GetComponent<Image>().sprite = Resources.Load<Sprite>(picturePath);
        SpriteState spState = new SpriteState();
        btnName.transition = Selectable.Transition.SpriteSwap;
        spState.highlightedSprite = Resources.Load<Sprite>(picturelinePath);
        btnName.spriteState = spState;
    }
}
