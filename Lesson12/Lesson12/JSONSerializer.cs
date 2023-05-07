using Newtonsoft.Json;
using SecondLesson;

namespace Serialization
{
    public class JSONSerializer
    {
        public string Serialize(Gun gun)
        {
            var json = JsonConvert.SerializeObject(gun);
            Console.WriteLine(json);
            return json;
        }

        public Gun Deserialize(string json)
        {
            var deserializedEmployee = JsonConvert.DeserializeObject<Gun>(json);
            Console.WriteLine(deserializedEmployee);
            return deserializedEmployee;
        }
    }
}
