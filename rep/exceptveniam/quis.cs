string json = JsonHelper.ToJson(myArray);
T[] array = JsonHelper.FromJson<T>(json);
