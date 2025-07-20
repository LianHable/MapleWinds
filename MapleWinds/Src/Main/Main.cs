namespace MapleWinds;

public class GameInstance : Window
{
    protected override void OnLoad()
    {
        Image icon = Raylib.LoadImage("../../../Assets/Icon.png");
        SetWindowProperties("MapleWinds", icon);
    }

    protected override void OnUpdate()
    {
        Raylib.ClearBackground(Color.Gold);

        if (Raylib.IsKeyPressed(KeyboardKey.F11))
        {
            Raylib.ToggleFullscreen();
        }
    }

    protected override void OnResize()
    {
        
    }

    protected override void OnUnload()
    {
        
    }
}