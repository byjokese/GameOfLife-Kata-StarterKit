// See https://aka.ms/new-console-template for more information

using System;
using GameOfLife.Logic;

Board board = Board.Random();
Console.WriteLine("Generation #0");
board.Print();

// First Generation
System.Console.WriteLine("First generation:");
board.Evolve();
board.Print();

// Iterate over 3 generations
// int maxGenerations = 3;
// for (int genIndex = 1; genIndex <= maxGenerations; genIndex++)
// {
//     board.Evolve();
//     Console.WriteLine("Generation #{0}", genIndex);
//     board.Print();
// }