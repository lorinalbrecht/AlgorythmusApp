﻿using AlgorythmusApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AlgorythmusApp.Controllers
{
    public class BuildingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /* public int[,] Field = { { 11, 12, 13, 14, 15, 16, 17, 18, 19 },
                                { 21, 22, 23, 24, 25, 26, 27, 28, 29 },
                                { 31, 32, 33, 34, 35, 36, 37, 38, 39 },
                                { 41, 42, 43, 44, 45, 46, 47, 48, 49 },
                                { 51, 52, 53, 54, 55, 56, 57, 58, 59 },
                                { 61, 62, 63, 64, 65, 66, 67, 68, 69 },
                                { 71, 72, 73, 74, 75, 76, 77, 78, 79 },
                                { 81, 82, 83, 84, 85, 86, 87, 88, 89 } }; */

        public void Seed()
        {
            BuildingInBase Silo1 = new( 1, 3, 4, 8, 2, 5);
        }
    }
}
