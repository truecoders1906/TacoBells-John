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
            logger.LogInfo(line);
            
            string[] curLine = new string[3];
            
            
              
            

            // Do not fail if one record parsing fails, return null
            return null; // TODO Implement
        }
    }
}