namespace WeatherApp
{
    public class EndPoints
    {
        public static string GetGeoAplifyEndPoint(string cityName)
        {
           //return $"https://api.geoapify.com/v1/geocode/search?text=Bilbao&format=json&apiKey=ed907bcaa07a43a09bf900649ee59313";
           return $"https://api.geoapify.com/v1/geocode/search?text={cityName}&format=json&apiKey={Config.GeoAplifyKey}";
        }

        public static string GetWeayherEndPoint(float lat, float lon)
        {
            var url = $"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m,relativehumidity_2m&hourly=temperature_2m&daily=weathercode,temperature_2m_max,temperature_2m_min&timezone=Europe%2FLondon";
            return url;
        }
    }
}