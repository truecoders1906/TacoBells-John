﻿using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;


namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        

        static void Main(string[] args)
        {
            logger.LogInfo("Log initialized"); // print logs to console

            var lines = File.ReadAllLines(csvPath); //array designed to read locations a

            logger.LogInfo($"Lines: {lines[0]}");

            var parser = new TacoParser();

            var locations = lines.Select(parser.Parse).ToArray();

            ITrackable taco1 = null;
            ITrackable taco2 = null;
            double distance = 0;
            
            for (int i = 0; i < locations.Length; i++)
            {

               ITrackable locA = locations[i];
               var corA = new GeoCoordinate( locA.Location.Latitude, locA.Location.Longitude);


                for (int k = 0; k < locations.Length; k++)
                {
                    ITrackable locB = locations[k];
                    var corB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);
                    double distanceTest = corA.GetDistanceTo(corB);
                    if(distanceTest > distance)
                    {
                        taco1 = locA;
                        taco2 = locB;


                        distance = distanceTest;

                    }
                    
                }
                
                
            }
            Console.WriteLine(taco1.Name, taco2.Name);

            // TODO:  Find the two Taco Bells in Alabama that are the furthest from one another.
            // HINT:  You'll need two nested forloops
        }
        
    }
}