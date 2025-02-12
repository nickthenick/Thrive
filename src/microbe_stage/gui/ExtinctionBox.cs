﻿using Godot;

public class ExtinctionBox : CustomDialog
{
    [Export]
    public NodePath ExtinctionMenuPath = null!;

    [Export]
    public NodePath LoadMenuPath = null!;

    private Control extinctionMenu = null!;
    private Control loadMenu = null!;

    public override void _Ready()
    {
        extinctionMenu = GetNode<Control>(ExtinctionMenuPath);
        loadMenu = GetNode<Control>(LoadMenuPath);
    }

    public override void _EnterTree()
    {
        base._EnterTree();

        InputManager.RegisterReceiver(this);
    }

    public override void _ExitTree()
    {
        base._ExitTree();

        InputManager.UnregisterReceiver(this);
    }

    [RunOnKeyDown("ui_cancel", Priority = Constants.SUBMENU_CANCEL_PRIORITY)]
    public bool LoadMenuEscapePressed()
    {
        if (!loadMenu.Visible)
            return false;

        loadMenu.Hide();
        extinctionMenu.Show();
        return true;
    }

    private void OpenLoadGamePressed()
    {
        GUICommon.Instance.PlayButtonPressSound();

        extinctionMenu.Hide();
        loadMenu.Show();
    }

    private void CloseLoadPressed()
    {
        GUICommon.Instance.PlayButtonPressSound();

        loadMenu.Hide();
        extinctionMenu.Show();
    }

    private void ReturnToMenuPressed()
    {
        GUICommon.Instance.PlayButtonPressSound();

        // This now just prints an error if we are paused here, this used to unpause but when refactoring the pausing
        // what should have paused the game before this wasn't found so this was probably just a safety check
        if (PauseManager.Instance.Paused)
            GD.PrintErr("Game is unexpectedly paused when closing the extinction screen");

        TransitionManager.Instance.AddSequence(ScreenFade.FadeType.FadeOut, 0.1f, OnSwitchToMenu, false);
    }

    /// <summary>
    ///   Finishes the transition back to the main menu
    /// </summary>
    private void OnSwitchToMenu()
    {
        SceneManager.Instance.ReturnToMenu();
    }
}
