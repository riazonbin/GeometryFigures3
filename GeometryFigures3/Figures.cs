// Sharipov Kamil 220th group, 24.05.22 Figures-3

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;

namespace GeometryFigures3
{
    public static class Figures
    {
        static List<Figure> listOfFigures = new List<Figure>();

        public static void Add(Figure figure)
        {
            listOfFigures.Add(figure);
        }

        public static void Clear()
        {
            listOfFigures.Clear();
        }

        public static void Save(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, listOfFigures);
            }
        }

        public static void Load(string path)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                listOfFigures = (List<Figure>)binaryFormatter.Deserialize(fileStream);
            }
        }
        public static string Draw()
        {
            string result = "";

            foreach (var figure in listOfFigures)
            {
                result += $"{figure.Draw() + Environment.NewLine}";
            }

            return result;
        }

        public static Figure LastFigure()
        {
            return listOfFigures.Last();
        }
    }
}
