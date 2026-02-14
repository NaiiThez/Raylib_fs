open Raylib_fs

[<EntryPoint>]
let main argv =

    Raylib_fs.InitWindow(800, 600, "Hello Raylib from F#")
    Raylib_fs.SetTargetFPS(60)

    while not (Raylib_fs.WindowShouldClose()) do
        Raylib_fs.BeginDrawing()
        Raylib_fs.ClearBackground(uint (0x000000u)) // White background
        Raylib_fs.DrawFPS(10, 10)

        Raylib_fs.DrawText("Hello, Raylib!", 200, 200, 40, uint (0xFFFFFFFFu)) // Red text
        Raylib_fs.EndDrawing()

    0
