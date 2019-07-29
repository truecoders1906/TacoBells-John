﻿using System;
namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();

        public ITrackable Parse(string line)
        {
            var cells = line.Split(',');

            if(cells.Length < 3)
            {
                return null;
            }
           
            
            
            Point curLocation = new Point();

            curLocation.Latitude = double.Parse(cells[0]); 

            curLocation.Longitude = double.Parse(cells[1]);
            string Name = cells[2];

            TacoBell taco = new TacoBell();

            taco.Name = Name;
            taco.Location = curLocation;

            return taco;


        }
        
            
            
           
              
            

            // Do not fail if one record parsing fails, return null
            //return null; // TODO Implement
        
    }
}