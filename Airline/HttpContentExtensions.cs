using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Airline
{
    public static class HttpContentExtensions
    {
        public static async Task<T> ReadAsync<T>(this HttpContent httpContent) where T : Response,new()
        {
            var response = new T();
            
            var serializer = new XmlSerializer(typeof(T));

            using (var stream = await httpContent.ReadAsStreamAsync().ConfigureAwait(false))
            {
                if (!(serializer.Deserialize(stream) is T deserializedObject))
                {
                    return response.Failed<T>("Deserialized process has failed!");
                }

                return deserializedObject;
            }
        }
    }
}    