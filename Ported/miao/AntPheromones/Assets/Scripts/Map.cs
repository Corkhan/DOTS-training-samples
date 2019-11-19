﻿namespace AntPheromones_ECS
{
    public static class Map
    {
        public const int Width = 128;

        public static bool IsWithinBounds(int positionX, int positionY)
        {
            return positionX >= 0 && positionY >= 0 && positionX < Width && positionY < Width;
        }
    }
}