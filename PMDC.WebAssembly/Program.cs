using System;
using RogueEssence;
using RogueEssence.Content;

namespace PMDC.WebAssembly
{

    class Program
    {
        static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Diagnostics.Tracing.EventSource.IsSupported", false);
            PathMod.InitExePath("/Content");
            DiagManager.InitInstance();
            DiagManager.Instance.DevMode = true;
            GraphicsManager.InitParams();
            using (GameBase game = new GameBase())
                game.Run();
        }
    }
}