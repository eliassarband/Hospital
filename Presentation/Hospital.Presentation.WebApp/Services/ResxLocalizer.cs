using Telerik.Blazor.Services;

namespace Hospital.Presentation.WebApp.Services
{
    public class ResxLocalizer : ITelerikStringLocalizer
    {
        // this is the indexer you must implement
        public string this[string name]
        {
            get
            {
                return GetStringFromResource(name);
            }
        }

        // sample implementation - uses .resx files in the ~/Resources folder names TelerikMessages.<culture-locale>.resx
        public string GetStringFromResource(string key)
        {
            return Resources.TelerikMessages.ResourceManager.GetString(key, Resources.TelerikMessages.Culture);
        }
    }
}
