﻿namespace SimpleSnake.GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Foods;

    public class Snake
    {
        private const char snakeSymbol = '\u25CF';

        private readonly Wall wall;
        private readonly Queue<Point> snakeElements;
        private readonly Food[] foods;

        private int foodIndex;
        private int nextLeftX;
        private int nextTopY;

        public Snake(Wall wall)
        {
            this.wall = wall;

            this.snakeElements = new Queue<Point>();
            this.foods = new Food[3];

            this.foodIndex = this.RandomFoodNumber;

            this.GetFoods();
            this.CreateSnake();
        }

        public int RandomFoodNumber =>
            new Random().Next(0, this.foods.Length);

        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead = this.snakeElements.Last();

            this.GetNextPoint(direction, currentSnakeHead);

            bool isPointOfSnake = this.snakeElements
                .Any(x => x.LeftX == this.nextLeftX &&
                          x.TopY == this.nextTopY);

            if (isPointOfSnake)
            {
                return false;
            }

            Point snakeNewHead = new Point(this.nextLeftX, this.nextTopY);

            if (this.wall.IsPointOfWall(snakeNewHead))
            {
                return false;
            }

            this.snakeElements.Enqueue(snakeNewHead);
            snakeNewHead.Draw(snakeSymbol);

            if (this.foods[this.foodIndex].IsFoodPoint(snakeNewHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = this.snakeElements.Dequeue();
            snakeTail.Draw(' ');

            return true;
        }

        private void CreateSnake()
        {
            for (int topY = 1; topY <= 6; topY++)
            {
                this.snakeElements.Enqueue(new Point(2, topY));   
            }

            // Create food on the deck
            this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
        }

        private void GetFoods()
        {
            this.foods[0] = new FoodHash(this.wall);
            this.foods[1] = new FoodDollar(this.wall);
            this.foods[2] = new FoodAsterisk(this.wall);
        }

        private void GetNextPoint(Point direction, Point snakeHead)
        {
            this.nextLeftX = snakeHead.LeftX + direction.LeftX;
            this.nextTopY = snakeHead.TopY + direction.TopY;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int length = this.foods[this.foodIndex].FoodPoints;

            for (int i = 0; i < length; i++)
            {
                this.snakeElements.Enqueue(new Point(this.nextLeftX, this.nextTopY));
                this.GetNextPoint(direction, currentSnakeHead);
            }

            this.foodIndex = this.RandomFoodNumber;
            this.foods[this.foodIndex].SetRandomPosition(this.snakeElements);
        }
    }
}
