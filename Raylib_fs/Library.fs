namespace Raylib_fs

open System.Runtime.InteropServices

module Raylib_fs =
    /// <summary>Initialise une fenêtre de jeu avec les dimensions spécifiées et un titre.</summary>
    /// <param name="width"> Largeur de la fenêtre en pixels.</param>
    /// <param name ="height"> Hauteur de la fenêtre en pixels.</param>
    /// <param name ="title"> Titre de la fenêtre.</param>
    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void InitWindow(int width, int height, string title)

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void CloseWindow()

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern bool WindowShouldClose()

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void SetTargetFPS(int fps)

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void BeginDrawing()

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void ClearBackground(uint color)

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void EndDrawing()

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void DrawText(string text, int posX, int posY, int fontSize, uint color)

    [<DllImport("raylib", CallingConvention = CallingConvention.Cdecl)>]
    extern void DrawFPS(int posX, int posY)
