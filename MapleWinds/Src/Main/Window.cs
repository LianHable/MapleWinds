namespace MapleWinds;

public class Window : IDisposable
{
    private int width = 800;
    private int height = 480;
    private string title = "Window";

    private int tartgetUpdateRate = 60;

    protected virtual void OnLoad() { }
    protected virtual void OnUpdate() { }
    protected virtual void OnResize() { }
    protected virtual void OnUnload() { }

    public void Run()
    {
        Raylib.SetConfigFlags(ConfigFlags.ResizableWindow | ConfigFlags.AlwaysRunWindow);
        Raylib.InitWindow(width, height, title);
        Raylib.SetTargetFPS(tartgetUpdateRate);

        OnLoad();
        
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            OnUpdate();

            if (Raylib.IsWindowResized())
            {
                // Update the window size and call OnResize
                width = Raylib.GetScreenWidth();
                height = Raylib.GetScreenHeight();
                OnResize();
            }

            Raylib.EndDrawing();
        }

        OnUnload();
        Raylib.CloseWindow();
    }

    protected void SetWindowProperties(string title, Image icon)
    {
        this.title = title;
        Raylib.SetWindowTitle(title);
        Raylib.SetWindowIcon(icon);
    }

    protected void SetTargetFPS(int fps)
    {
        tartgetUpdateRate = (int)Math.Clamp(fps, 1, 10000);
        Raylib.SetTargetFPS(tartgetUpdateRate);
    }

    protected void SetWindowSize(int newWidth, int newHeight)
    {
        width = newWidth;
        height = newHeight;
        Raylib.SetWindowSize(width, height);
        Raylib.SetWindowTitle($"{title} - {width}x{height}");
    }

    protected bool IsWindowResizing()
    {
        int currentWidth = Raylib.GetScreenWidth();
        int currentHeight = Raylib.GetScreenHeight();
        return currentWidth != width || currentHeight != height;
    }

    public void Dispose() { }
}

public static class EntryPoint
{
    [STAThread]
    public static void Main()
    {
        using var game = new GameInstance();
        game.Run();
    }
}