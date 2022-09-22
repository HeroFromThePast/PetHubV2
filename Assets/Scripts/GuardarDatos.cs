using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class GuardarDatos
{
    public static void GuardarPerro (Estadisticas stats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/perro.datosPerro";
        FileStream stream = new FileStream(path, FileMode.Create);

        DatosPerro dPerro = new DatosPerro(stats);

        formatter.Serialize(stream, dPerro);
        stream.Close();
    }

    public static DatosPerro CargarDatos()
    {
        string path = Application.persistentDataPath + "/perro.datosPerro";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            DatosPerro dPerro = formatter.Deserialize(stream) as DatosPerro;
            stream.Close();

            return dPerro;
        }else
        {
            Debug.LogError("No se encontró el archivo en " + path);
            return null;
        }
    }
}
