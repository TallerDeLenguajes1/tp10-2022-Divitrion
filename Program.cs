using System.Text.Json;
using System.Net;

get();


static void get()
{
    var url = $"https://age-of-empires-2-api.herokuapp.com/api/v1/civilizations";
    var request = (HttpWebRequest)WebRequest.Create(url);
    request.Method = "GET";
    request.ContentType = "application/json";
    request.Accept = "application/json";

    try
    {
        using (WebResponse response = request.GetResponse())
        {
            using (Stream strReader = response.GetResponseStream())
            {
                if (strReader == null) return;
                using (StreamReader objReader = new StreamReader(strReader))
                {
                    string responseBody = objReader.ReadToEnd();
                    Root listaCivilizaciones = JsonSerializer.Deserialize<Root>(responseBody);
                    foreach (Civilization civ in listaCivilizaciones.civilizations)
                    {
                        civ.show();
                    }
                    Console.WriteLine("Quiere mostrar una civilizacion en especifico? ingrese la id.");
                    int id=Convert.ToInt32(Console.ReadLine());

                    foreach (var civ in listaCivilizaciones.civilizations)
                    {
                        if (civ.id==id)
                        {
                            civ.show();
                        }
                    }
                }
            }
        }
    }
    catch (System.Exception)
    {

        throw;
    }
}

