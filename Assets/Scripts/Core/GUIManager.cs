using System;
using UnityEngine;
using System.Collections.Generic;

public class GUIManager : MonoBehaviour
{
    private List<MonoBehaviour> rects;

    [Serializable]
    public class GuiRects
    {
        public MainMenuRect mainMenuRect;
        public GameSceneRect gameSceneRect;
    }

    public GuiRects guiRects = new GuiRects();
    public void Initialize()
    {
        gameObject.SetActive(true);

        rects = new List<MonoBehaviour>();
        rects.Add(guiRects.mainMenuRect);
        rects.Add(guiRects.gameSceneRect);

        CloseAll();

        OpenMainMenuRect();
    }
    private void CloseAll()
    {
        for (int i = 0; i < rects.Count; i++)
            rects[i].gameObject.SetActive(false);
    }

    public void OpenMainMenuRect()
    {
        CloseAll();
        guiRects.mainMenuRect.Initialize();
    }
    public void OpenGameSceneRect()
    {
        CloseAll();
        guiRects.gameSceneRect.Initialize();
    }


}
