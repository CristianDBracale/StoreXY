using System.Resources;

namespace StoreXY.ResourcesManager
{
    public class Resources
    {
        public static string GetMessage(string resource)
        {
            ResourceManager res_msg = new ResourceManager(typeof(Properties.Resources));

            string str = res_msg.GetString(resource);

            return str;
        }
    }
}
