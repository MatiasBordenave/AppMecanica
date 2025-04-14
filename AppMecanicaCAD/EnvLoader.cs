using System;
using System.Collections.Generic;
using System.IO;

namespace AppMecanicaCAD
{
    public static class EnvLoader
    {
        public static Dictionary<string, string> Load(string filePath)
        {
            var envVars = new Dictionary<string, string>();

            if (!File.Exists(filePath)) return envVars;

            foreach (var line in File.ReadAllLines(filePath))
            {
                if (string.IsNullOrWhiteSpace(line) || line.Trim().StartsWith("#")) continue;

                var parts = line.Split('=', 2);
                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();
                    envVars[key] = value;
                }
            }

            return envVars;
        }
    }
}
